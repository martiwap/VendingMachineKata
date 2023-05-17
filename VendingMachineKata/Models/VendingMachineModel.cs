using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineKata.Services;

namespace VendingMachineKata.Models
{
    public class VendingMachineModel
    {
        // I am assuming that the machine stores 10x of each item
        public List<ItemModel> ItemsAvailable = new List<ItemModel>()
        {
            new ItemModel(1.00, "cola", 10),
            new ItemModel(0.50, "crisps", 10),
            new ItemModel(0.65, "chocolate", 10),
        };

        public double Balance { get; set; }

        public IValidateInputService validateInputService { get; set; }
        public IDisplayMessagesService messagesService { get; set; }

        public void SetInitialBalance(double moneyInserted)
        { 
            this.Balance = moneyInserted;
        }

        public void Purchase(ItemModel itemPurchased)
        {
            if (!validateInputService.IsMoneyInsertedEnough(this.Balance, itemPurchased.Price))
                messagesService.ShowExactChangeOnly();

            var item = this.ItemsAvailable.Where(x => x.Name == itemPurchased.Name).FirstOrDefault();
            if (item is not null)
            {
                // update quantity
                item.Quantity = item.Quantity - 1;
                // update balance
                this.Balance = this.Balance - itemPurchased.Price;

                if (this.Balance > 0)
                {
                    // display change or remaining balance
                    messagesService.ShowBalance(this.Balance);
                }
            }
            else
                messagesService.ShowSoldOut();

        }

        public void ProcessMoneyEntered(object input, double amountEntered)
        {
            if (!validateInputService.IsInputValid(input))
                return;

            amountEntered = amountEntered + validateInputService.ConvertInputToValue(input);

            this.Balance += amountEntered;
        }


    }
}
