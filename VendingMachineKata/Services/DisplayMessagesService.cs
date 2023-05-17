using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineKata.Models;

namespace VendingMachineKata.Services
{
    public class DisplayMessagesService : IDisplayMessagesService
    {
        public void SayThanks()
        {
            Console.WriteLine("THANK YOU");
        }

        public void ShowExactChangeOnly()
        {
            Console.WriteLine("EXACT CHANGE ONLY");
        }

        public void ShowInsertCoin()
        {
            Console.WriteLine("INSERT COIN");
        }

        public void ShowPrice(ItemModel item)
        {
            Console.WriteLine($"£ {item.Price}");
        }

        public void ShowBalance(double balance)
        {
            Console.WriteLine($"£ {balance}");
        }

        public void ShowSoldOut()
        {
            Console.WriteLine("SOLD OUT");
        }
    }

    public interface IDisplayMessagesService
    {
        void ShowInsertCoin();
        void ShowSoldOut();
        void SayThanks();
        void ShowExactChangeOnly();
        void ShowPrice(ItemModel item);
        void ShowBalance(double balance);
    }
}