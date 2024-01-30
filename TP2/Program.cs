using System;

namespace TP2
{
  class Program
  {
    // Largeur de la console
    const int CONSOLE_WIDTH = 5 * Display.DICE_WIDTH;
    // Nombre d'itérations où le joueur peut changer ses dés (max 10 ici)
    const int NUM_DRAWS = 10;

    static void Main(string[] args)
    {
          Display.Clear();
      Console.WindowWidth = CONSOLE_WIDTH;

      bool[] availableDices = new bool[Game.NUM_FACES];
      for (int i = 0; i < availableDices.Length; i++)
        availableDices[i] = true;

      int[] dicesValues = new int[Game.NUM_FACES_IN_HAND];

      bool[] selectedDices = new bool[Game.NUM_FACES_IN_HAND];
      for (int i = 0; i < selectedDices.Length; i++)
        selectedDices[i] = false;

      Game.DrawFaces(dicesValues, selectedDices, availableDices);
      for (int i = 0; i < NUM_DRAWS; i++)
      {
        // Afficher les cartes
        Display.ShowDices(dicesValues);
        // Afficher les consignes
        Display.ShowInstructions();
        // Afficher la meilleure main à date
        Game.ShowHand(dicesValues);
        // Permettre au joueur de sélectionner les cartes à garder
        Display.SelectDices(selectedDices);
        // Relancer les cartes que le joueur ne veut pas garder.
        Game.DrawFaces(dicesValues, selectedDices, availableDices);
      }

      Display.WriteString("", 0, Console.WindowHeight - 2, ConsoleColor.Black);
    }
  }
}
