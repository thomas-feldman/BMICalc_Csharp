using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignment {
    /* Calculates waist and hieght measurements 
    * and displays the ratio of risk in relation to
    * developing obesity related cardiovascular diseases.
    * 
    * Author: Thomas Feldman, n8306699 
    * Date: March 2017 
    *   
    */
    class Program {
        static void Main() {         
            Welcome();
            WaistHeightRatio();
            AnotherCalculation();
        }//End Main

        static void Welcome() {
            Console.Write("Welcome to the Waist to Height Ratio Calculator");
        }//End Welcome Message

        static double WaistInput() {
            // Set variable for waist
            double waist = 0.0; 
            do {
                Console.Write("\n\nPlease Enter Waist Measurement in cm: ");
                // Write to console, and save value
                waist = double.Parse(Console.ReadLine());
                // Check if greater than 60
                if(waist < 60) {
                    Console.Write("Input value greater than 60.0cm");
                }
            } while(waist < 60);
            return waist;
        }//End WaistInput

        static double HeightInput() {
            // Set variable for height
            double height = 0.0;
            do {
                Console.Write("\n\nPlease Enter Height Measurement in cm: ");
                // Write to console window and save height value
                height = double.Parse(Console.ReadLine());
                if(height < 120) {
                    //check greater than 120
                    Console.Write("Input value greater than 120.0cm");
                }
            } while(height < 120);
            return height;
        }//End HeightInput

        static string GenderInput() {
            // Set variable for gender
            string gender;
            do {
                string menu = "\nAre you"
                         + "\n1) Male"
                         + "\n2)Female"
                         + "\nEnter your option(1 or 2): ";
                //write menu for gender selection
                Console.Write(menu);
                gender = Console.ReadLine();
                //Save value
                if(gender != "1" && gender != "2") {
                    // check for valid response
                    Console.Write("Please enter a valid response of 1 or 2");
                }
            } while(gender != "1" && gender != "2");
            return gender;
        }//End GenderInput

        static double WaistHeightRatio() {
            // Set variable for ratio
            double ratio = 0.0;
            ratio = WaistInput() / HeightInput();
            //do ratio calculation and check for gender
            if(GenderInput() == "1") {
                if(ratio < 0.536) {
                    Console.Write("\nYour waist to height ratio is: " + ratio + ".\n and \nYou are are a Low Risk Male");
                } else {
                    Console.Write("Your waist to height ratio is: " + ratio + ".\n and \nYou are are a High Risk Male");
                }
            } else {
                if(ratio < 0.492) {
                    Console.Write("Your waist to height ratio is: " + ratio + ".\n and \nYou are are a Low Risk Female");
                } else {
                    Console.Write("Your waist to height ratio is: " + ratio + ".\n and \nYou are are a High Risk Female");
                }
            }
            return ratio;
        }//End Ratio converstion

        static void ExitProgram() {
            Console.Write("\n\nPress any key to exit.");
            Console.ReadKey();
        }//EXITS Gracefully

        static void AnotherCalculation() {
            //Asks user for another calulation
            Console.WriteLine("\n\nAnother Calculation? <Y>es or <N>o");
            ConsoleKeyInfo input = Console.ReadKey();
            Console.WriteLine();
            if(input.KeyChar == 'n' || input.KeyChar == 'N') {
                ExitProgram();
            }else if(input.KeyChar == 'Y' || input.KeyChar == 'y') {
                Main();
            }else {
                Console.Write("\n\nPlease enter a valid response");
                Console.ReadKey();
            }
        }//End Another Calculation
    }
}
