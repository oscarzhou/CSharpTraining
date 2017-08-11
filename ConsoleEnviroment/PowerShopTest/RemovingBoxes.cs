using System;
using System.Collections.Generic;

namespace ConsoleEnviroment.PowerShopTest
{
    class RemovingBoxes
    {
        static void Main(string[] args)
        {
            //Initialize the variables
            int counter = 41;
            string letters = "aabbccddeeffgghhiijj";
            char[] boxes = letters.ToCharArray();
            int boxIndex = 0; // The number of current box selected and also used for intialized the key of dictionary 
            char previousLetter = '-';
            int previousIndex = 0;

            Dictionary<int, char> dicBoxes = new Dictionary<int, char>();
            // This dictionary collection is used for iteratelly checking which box is left.
            foreach (char letter in boxes)
            {
                dicBoxes.Add(boxIndex++, letter);
            }

            //Interaction Part
            while (true)
            {
                counter--;
                //Display the numbers of the box
                int numOfLeftBoxes = 0; // One of the condition to determine if the user wins
                Console.WriteLine("The current existed boxes are :");
                foreach (int key in dicBoxes.Keys)
                {
                    if (dicBoxes[key] != '-')
                    {
                        Console.WriteLine((key + 1).ToString() + " ");
                        numOfLeftBoxes++;
                    }
                }
                Console.WriteLine();

                //Select box and determine if the boxes can be removed
                Console.WriteLine("Please select the number of the box that you want to see: ");
                boxIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("The letter in the Box " + boxIndex + " is" + boxes[boxIndex]);
                if (counter == 40)
                {
                    previousLetter = boxes[boxIndex];
                    previousIndex = boxIndex;
                    Console.ReadKey();
                }
                else
                {
                    if (previousLetter == boxes[boxIndex])
                    {
                        //Remove these two boxes
                        dicBoxes[previousIndex] = '-';
                        dicBoxes[boxIndex] = '-';
                        previousLetter = boxes[boxIndex];
                        previousIndex = boxIndex;
                    }
                    else
                    {
                        previousLetter = boxes[boxIndex];
                        previousIndex = boxIndex;
                        Console.ReadKey();
                    }
                }

                //The condition of winning
                if (numOfLeftBoxes == 2 && counter > 1)
                {
                    break;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Sorry, you lose");
            }
            else
            {
                Console.WriteLine("Congrats, you win");
            }
            Console.ReadKey();
        }
    }
}
