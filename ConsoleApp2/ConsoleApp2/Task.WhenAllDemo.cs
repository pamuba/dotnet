using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TaskDemo
    {
        static void Main(){
            Console.WriteLine("main thread started");
            List<CreditCard> creidCards = CreditCard.GenerateCreditCards(10);

            ProcessCreditCards(creidCards);
            
            Console.WriteLine("main thread ended");
            Console.ReadLine();
        }
        public static async void ProcessCreditCards(List<CreditCard> creditCards) {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var tasks = new List<Task<string>>();


            //await Task.Run
            //Processing
            foreach (var creditCard in creditCards)
            {
                var response = ProcessCard(creditCard);
                tasks.Add(response);
            }

            //execute all tasks concurrenlty
            await Task.WhenAll(tasks);

            //foreach (var creditCard in creditCards) {
            //    var response = await ProcessCard(creditCard);
            //    Console.WriteLine(response);
            //}

            stopWatch.Stop();
            Console.WriteLine($"Processing of {creditCards.Count} Credit Cards" +
                $"Done in {stopWatch.ElapsedMilliseconds/1000} Seconds");
        }

        public static async Task<string> ProcessCard(CreditCard creditCard) { 
            await Task.Delay(1000);
            Console.WriteLine($"Credit Card Number:{creditCard.CardNumber} Name: {creditCard.Name} Processed");

            return $"Credit Card Number:{creditCard.CardNumber} Name: {creditCard.Name} Processed";
        }
    }
    //so its ok to not have async if we dont use await
    public class CreditCard { 
        public string CardNumber { get; set; }
        public string Name { get; set; }

        public static List<CreditCard> GenerateCreditCards(int number) { 
            List<CreditCard> creditCards = new List<CreditCard>();
            for (int i = 0; i < number; i++)
            {
                CreditCard card = new CreditCard()
                {
                    CardNumber = "1001" + i,
                    Name = "CreditCard-" + i
                };
                creditCards.Add(card);
            }
            return creditCards;
        }

    }
}
