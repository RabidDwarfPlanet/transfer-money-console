using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
        public Simulation()
        {
            
        }

        public void RunSimulation()
        {
            Console.WriteLine("Starting simulation \n");
            Console.WriteLine("Known Users");
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines.

            Person userOne = new Person("Dan", 50);
            Person userTwo = new Person("Mike", 100);
            Person userThree = new Person("Sandy", 220);
            Person userFour = new Person("Debbie", 500);
            Person userFive = new Person("Jenn", 5000);

            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.
            userOne.DisplayInfo();
            userTwo.DisplayInfo();
            userThree.DisplayInfo();
            userFour.DisplayInfo();
            userFive.DisplayInfo();

            Console.WriteLine("\nWho would you like tranfer the money?");
            Person selectedUserOne = null;
            Person selectedUserTwo = null;

            while (selectedUserOne == null)
            {
                string giverUserName = Console.ReadLine();

                switch (giverUserName.ToLower())
                {
                    case "dan":
                        selectedUserOne = userOne;
                        break;
                    case "mike":
                        selectedUserOne = userTwo;
                        break;
                    case "sandy":
                        selectedUserOne = userThree;
                        break;
                    case "debbie":
                        selectedUserOne = userFour;
                        break;
                    case "jenn":
                        selectedUserOne = userFive;
                        break;
                    default:
                        Console.WriteLine("Invalid User, Please try again");
                        break;
                        
                }

            }

            Console.WriteLine("\nWho would you like them to tranfer the money to?");
            while (selectedUserTwo == null)
            {
                string receiverUserName = Console.ReadLine();

                switch (receiverUserName.ToLower())
                {
                    case "dan":
                        selectedUserTwo = userOne;
                        break;
                    case "mike":
                        selectedUserTwo = userTwo;
                        break;
                    case "sandy":
                        selectedUserTwo = userThree;
                        break;
                    case "debbie":
                        selectedUserTwo = userFour;
                        break;
                    case "jenn":
                        selectedUserTwo = userFive;
                        break;
                    default:
                        Console.WriteLine("Invalid User, Please try again");
                        break;

                }

            }






            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!

            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.

            Console.WriteLine("\nHow much would you like to transfer?");
            int transferAmount = int.Parse(Console.ReadLine());

            selectedUserOne.TransferMoney(selectedUserTwo, transferAmount);

            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.

            selectedUserOne.DisplayInfo();
            selectedUserTwo.DisplayInfo();

            Console.WriteLine("\nSimulation complete.");
        }
    }
}
