using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
  class Display
  {
    public const int DICE_WIDTH = 30;
    public const int DICE_HEIGHT = 14;
    public static readonly String[] BACKGROUND_LOGO = {
      "                         ",
      "                         ",
      "                         ",
      "                         ",
      "                         ",
      "                         ",
      "                         ",
      "                         ",
      "                         ",
      "                         ",
      "                         ",
      "                         "
    };

    public static void DrawArrayOfStrings(String[] logo, int posX, int posY, ConsoleColor color)
    {
      for (int i = 0; i < logo.Length; i++)
      {
        Display.WriteString(logo[i], posX, posY + i, color);
      }
    }
    public static void DrawDice(int value, int suit, int posX, int posY)
    {
      String[] border ={
      "*****************************",
      "*                           *",
      "*                           *",
      "*                           *",
      "*                           *",
      "*                           *",
      "*                           *",
      "*                           *",
      "*                           *",
      "*                           *",
      "*                           *",
      "*                           *",
      "*                           *",
      "*****************************",
      };
      
      ConsoleColor color = ConsoleColor.Green;
      String[] logo = BACKGROUND_LOGO;
      if (suit == Game.YELLOW)
      { 
        color = ConsoleColor.Yellow;
      }
      else if (suit == Game.GRAY)
      {
        color = ConsoleColor.Gray;
      }
      else if (suit == Game.BLUE)
      {
        color = ConsoleColor.Blue;
      }
      DrawArrayOfStrings(border, posX, posY, ConsoleColor.Black);

      
      Console.BackgroundColor = color;
      DrawArrayOfStrings (logo, posX + 2, posY + 1, color);

      // Dessiner les points selon les possibilités
      // 1(0),3(2),5(6) 
      if (value%2 == 0)
      {
        // Centre centre
        DrawCircle (posX + 14, posY + 6);
      }

      if (value == Game.D6)
      {
        // gauche centre
        DrawCircle (posX + 5, posY + 6);
        // droite centre
        DrawCircle (posX + 23, posY + 6);
      }
      
      if (value > Game.D1)
      {
        // haut gauche 
        DrawCircle (posX + 5, posY + 2);
        
      }
      
      if (value > Game.D3)
      {
        // Haut droite
        DrawCircle (posX + 23, posY + 2);
        // Bas gauche
        DrawCircle (posX + 5, posY + 10);       
      }
      if (value >= Game.D2)
      {        
        // Bas droite
        DrawCircle (posX + 23, posY + 10);
      }

      Console.BackgroundColor = ConsoleColor.White;
    }
    public static void DrawCircle(int centerPosX, int centerPosY)
    {
      WriteString ("X", centerPosX, centerPosY - 1, ConsoleColor.Black);
      WriteString ("XXX", centerPosX - 1, centerPosY, ConsoleColor.Black);
      WriteString ("X", centerPosX, centerPosY + 1, ConsoleColor.Black);
    }
    public static string ConvertHandToString ( int hand )
    {
      string stringRepresentationOfHand = "High dice";
      switch (hand)
      {
        case Game.ONE_PAIR:
        {
          stringRepresentationOfHand = "One pair";
          break;
        }
        case Game.TWO_PAIRS:
        {
          stringRepresentationOfHand = "Two pairs";
          break;
        }
        case Game.THREE_OF_A_KIND:
        {
          stringRepresentationOfHand = "Three of a kind";
          break;
        }
        case Game.STRAIGHT:
        {
          stringRepresentationOfHand = "Straight";
          break;
        }
        case Game.FLUSH:
        {
          stringRepresentationOfHand = "Flush";
          break;
        }
        case Game.FULL_HOUSE:
        {
          stringRepresentationOfHand = "Full house";
          break;
        }
        case Game.FOUR_OF_A_KIND:
        {
          stringRepresentationOfHand = "Four of a kind";
          break;
        }
        
        case Game.STRAIGHT_FLUSH:
        {
          stringRepresentationOfHand = "Straight flush";
          break;
        }
        case Game.ROYAL_FLUSH:
        {
          stringRepresentationOfHand = "Royal flush";
          break;
        }
      }
      return stringRepresentationOfHand;
    }
    public static void WriteString(String message, int posX, int posY, ConsoleColor color)
    {
      Console.SetCursorPosition(posX, posY);
      Console.ForegroundColor = color;
      Console.Write(message);
    }
    public static void Clear()
    {
      Console.BackgroundColor = ConsoleColor.White;
      Console.Clear();
      Console.CursorVisible = false;
    }
    public static void ShowDices(int[] cardValues)
    {
      Display.Clear();
      for (int i = 0; i < cardValues.Length; i++)
      {
        Display.DrawDice(Game.GetValueFromFaceIndex(cardValues[i]),
                          Game.GetColorFromFaceIndex(cardValues[i]),
                         i * DICE_WIDTH,
                         0);
      }
    }

    public static void ShowSelectedMarks(bool[] selectedCards)
    {
      for (int i = 0; i < selectedCards.Length; i++)
      {
        String text = "[ ]";
        if (selectedCards[i])
          text = "[X]";
        Display.WriteString(text, (DICE_WIDTH - text.Length) / 2 + i * DICE_WIDTH, DICE_HEIGHT + 2, ConsoleColor.Black);
      }
    }
    public static bool IsKeyAvailable()
    {
      return Console.KeyAvailable;
    }
    public static void HighLightText(String message, int posX, int posY)
    {
      Console.SetCursorPosition(posX, posY);
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write(message);
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
    }
    public static void SelectDices(bool[] selectedCards)
    {
      Display.ShowSelectedMarks(selectedCards);
      int current = 0;
      String symbol = " ";
      if (selectedCards[current])
        symbol = "X";
      Display.HighLightText(symbol, (Display.DICE_WIDTH - symbol.Length) / 2 + current * Display.DICE_WIDTH, Display.DICE_HEIGHT + 2);

      while (true)
      {
        if (Display.IsKeyAvailable())
        {
          ConsoleKey currentKey = Console.ReadKey().Key;
          if (currentKey == ConsoleKey.Enter)
            break;
          if (currentKey == ConsoleKey.Tab)
          {
            current = (current + 1) % selectedCards.Length;
          }
          if (currentKey == ConsoleKey.Spacebar)
            selectedCards[current] = !selectedCards[current];

          Display.ShowSelectedMarks(selectedCards);
          symbol = " ";
          if (selectedCards[current])
            symbol = "X";
          Display.HighLightText(symbol, (Display.DICE_WIDTH - symbol.Length) / 2 + current * Display.DICE_WIDTH, Display.DICE_HEIGHT + 2);
        }
      }
    }
    public static void ShowInstructions()
    {
      Display.WriteString("Appuyez sur espace pour sélectionner/désélectionner la carte.", 0, Display.DICE_HEIGHT + 10, ConsoleColor.Black);
      Display.WriteString("Appuyez sur tab pour passer à la carte suivante.", 0, Display.DICE_HEIGHT + 11, ConsoleColor.Black);
      Display.WriteString("Appuyez sur enter pour relancer les cartes.", 0, Display.DICE_HEIGHT + 12, ConsoleColor.Black);
    }

  }
}







