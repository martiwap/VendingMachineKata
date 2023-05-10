## VendingMachineKata
Initial draft of a known kata received as techtest

Note:
This took just under 2 hours, it is an initial thought of what I think it would be needed to complete this kata. 
- Ideally you would have a class/service that validates the input received (or money entered)
- a class/service that handles the messages displayed
- A vending machine class/model/entity that performes the action of selling the item requested.

There are no tests, as the assesment received stated that :
To be clear that while we practise TDD in some of our teams, unit tests are not required for this task – we will not look at them and they will not be considered when evaluating your task.

This is more the basic draft of how I first thought or approaching this solution and is open to discussions.
Ideally I would have wanted an engine class that is extended by the vending machine that handles the sale, calculcation of the money, and update on the inventory inside it. 


I paste here below what the assessment was:


# Technical Task
We’d like to find out a bit more about how you approach problem solving by completing a technical exercise. You should aim to spend around 2-3 hours on this technical task, but are free to spend as much or little of those 2-3 hours as you wish. Please upload your code sample to GitHub and submit the link. Don’t worry if you don’t complete all of the tasks, can’t get the code to compile or have any other issues. We’re most interested in seeing how it is you tackle problem solving, and we’re looking to understand why you’ve made the decisions you have when it comes to your solution.
Your solution will provide the basis for your technical interview where we will explore extending your solution given certain business challenges.  If you don’t finish then don’t worry just send over what you’ve got
To be clear that while we practise TDD in some of our teams, unit tests are not required for this task – we will not look at them and they will not be considered when evaluating your task
We recommend watching at least part of this video to get an idea of how we work - https://www.youtube.com/watch?v=UYmTUw5LXwQ  If you get a chance it would be good to watch it, we don’t expect you to watch the whole thing but there’s a useful section between 15-25 mins that gives an example of the way we work and if you can demonstrate that in your task we would recommend doing so

# The vending machine kata
In this exercise, you will build the brains of a vending machine. It will accept money, make change, maintain inventory, and dispense products. All the things that you might expect a vending machine to accomplish.

Features
# Accept Coins
As a vendor
I want a vending machine that accepts coins
So that I can collect money from the customer
The vending machine will accept valid coins (1p, 2p, 5p, 10p, 20p, 50p, £1, £2) and reject invalid ones (buttons, washers). When a valid coin is inserted the amount of the coin will be added to the current amount and the display will be updated. When there are no coins inserted, the machine displays INSERT COIN. Rejected coins are placed in the coin return.

# Select Product
As a vendor
I want customers to select products
So that I can give them an incentive to put money in the machine
There are three products: 
•	cola for £1.00, 
•	crisps for £0.50
•	chocolate for £0.65 
When the respective button is pressed and enough money has been inserted, the product is dispensed and the machine displays THANK YOU. If the display is checked again, it will display INSERT COIN and the current amount will be set to £0.00. If there is not enough money inserted then the machine displays PRICE and the price of the item and subsequent checks of the display will display either INSERT COIN or the current amount as appropriate.


# Make Change
As a vendor
I want customers to receive correct change
So that they will use the vending machine again
When a product is selected that costs less than the amount of money in the machine, then the remaining amount is placed in the coin return.

# Return Coins
As a customer
I want to have my money returned
So that I can change my mind about buying stuff from the vending machine
When the return coins button is pressed, the money the customer has placed in the machine is returned and the display shows INSERT COIN.

# Sold Out
As a customer
I want to be told when the item I have selected is not available
So that I can select another item
When the item selected by the customer is out of stock, the machine displays SOLD OUT. If the display is checked again, it will display the amount of money remaining in the machine or INSERT COIN if there is no money in the machine.

# Exact Change Only
As a customer
I want to be told when exact change is required
So that I can determine if I can buy something with the money I have before inserting it
When the machine is not able to make change with the money in the machine for any of the items that it sells, it will display EXACT CHANGE ONLY instead of INSERT COIN.

