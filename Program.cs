using PickRandomCards;
using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number of cards to pick: ");
        string line = Console.ReadLine();
        if (int.TryParse(line, out int numberOfCards))
        {
            foreach (string card in CardPicker.PickSomeCards(numberOfCards))
            {
                Console.WriteLine(card);
            }
        }
        else
        {
            Console.WriteLine("Please pick a valid number");
        }
    }
}