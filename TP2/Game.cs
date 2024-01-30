using System;

namespace TP2
{
  public class Game
  {
    public const int GREEN = 0;
    public const int YELLOW = 1;
    public const int GRAY = 2;
    public const int BLUE = 3;

    public const int D1 = 0;
    public const int D2 = 1;
    public const int D3 = 2;
    public const int D4 = 3;
    public const int D5 = 4;
    public const int D6 = 5;


    public const int HIGH_DICE = 0;
    public const int ONE_PAIR = 1;
    public const int TWO_PAIRS = 2;
    public const int THREE_OF_A_KIND = 3;
    public const int STRAIGHT = 4;
    public const int FLUSH = 5;
    public const int FULL_HOUSE = 6;
    public const int FOUR_OF_A_KIND = 7;
    public const int STRAIGHT_FLUSH = 9;
    public const int ROYAL_FLUSH = 10;

    public const int NUM_DICE_COLORS = 4;
    public const int NUM_FACES_PER_DICE = 6;
    public const int NUM_FACES = NUM_DICE_COLORS * NUM_FACES_PER_DICE;
    public const int NUM_FACES_IN_HAND = 5;

    public static int GetColorFromFaceIndex ( int index )
    {
      // A COMPLETER. Le code ci-après est incorrect
      return 0;
    }
    public static int GetValueFromFaceIndex ( int index )
    {
      // A COMPLETER. Le code ci-après est incorrect
      return 0;
    }

    public static void DrawFaces ( int[] facesValues, bool[] selectedFaces, bool[] availableFaces )
    {
      // A COMPLETER
      
    }


    public static int GetHand ( int[] cardValues )
    {
      int hand = HIGH_DICE;
      // A COMPLETER


      return hand;
    }


    // A COMPLETER
    // ...
    // Il manque toutes les méthodes pour trouver les paires, les doubles paires, les brelans, etc.
    // Référez-vous aux tests pour les noms de méthodes appropriés.

    public static void ShowHand(int[] cardValues)
    {
      int hand = GetHand(cardValues);
      Display.WriteString($"Vous avez actuellement {Display.ConvertHandToString(hand)}", 0, Display.DICE_HEIGHT + 14, ConsoleColor.Black);
    }
  }
}
