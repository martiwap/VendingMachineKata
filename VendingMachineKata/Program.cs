using System;
using System.Collections.Generic;
using VendingMachineKata.Models;
using VendingMachineKata.Services;

public class Program
{
    static void Main()
    {
        VendingMachineModel model = new VendingMachineModel();
        IDisplayMessagesService messagesService = new DisplayMessagesService();

        Console.WriteLine("Hello!");
        Console.WriteLine("Note, this machine only accepts (1p, 2p, 5p, 10p, 20p, 50p, £1, £2) ");
        messagesService.ShowInsertCoin();

        // create a new instance of the vending machine

        // take input on money entered

        // take input on item wanted

        // ideal process purchase 
        // ---> check money is valid and update balance
        // ---> update item available
        // ---> return any change if necessary

    }
}