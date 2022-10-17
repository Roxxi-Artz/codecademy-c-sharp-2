using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codecademy_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("GIVE ME YOUR BANK ACCOUNT LOGIN INFORMATION: ");
            string Info = Console.ReadLine();

            Console.Write($"HAHAHA NOW I CAN GET INTO YOUR BANK ACCOUNT WITH ${Info} AHAHAHAAHAHA oh wait you gave me the wrong stuff. uhhhh... whoops welp bye");




            /* Your Age
            int userAge = 30;

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;

            // Time to Jupiter
            double journeyToJupiter = 6.142466;

            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;

            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;

            // Log calculations to console
            Console.WriteLine(jupiterAge);
            Console.WriteLine(newEarthAge);
            Console.WriteLine(newJupiterAge);*/


            /* Number of pizza shops
            int pizzaShops = 4332;

            // Number of employees
            int totalEmployees = 86928;

            // Revenue
            decimal revenue = 390819.28m;

            // Log the values to the console:
            Console.WriteLine(pizzaShops);
            Console.WriteLine(totalEmployees);
            Console.WriteLine(revenue);*/


            /* Create Variables
            string name = "Shadow";
            string breed = "Golden Retriever";
            int age = 5;
            double weight = 65.22;
            bool spayed = true;

            // Print variables to the console
            Console.WriteLine(name);
            Console.WriteLine(breed);
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(spayed);

            // Ask user for fave number
            Console.Write("Enter your favorite number!: ");

            // Attempt 3: use Convert method
            int faveNumber = Convert.ToInt32(Console.ReadLine());
            
     
            int steps = 0;

            steps += 2;
      
            steps--;
     
            Console.WriteLine(steps);
            

            int students = 18;

            // Number of students in a group
            int groupSize = 3;

             // Does groupSize go evenly into students?
            Console.WriteLine(students % groupSize);
            
             
                   // Create variables 
            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

            // Use built-in methods and save to variable 
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Print the lowest number
            Console.WriteLine(Math.Min(numberTwoSqrt, numberOneSqrt));
            
             
            double numberOne = 6.5;
            double numberTwo = 4;

            // Raise numberOne to the numberTwo power
            Console.WriteLine(Math.Pow(numberOne, numberTwo));

            // Round numberOne up
            Console.WriteLine(Math.Ceiling(numberOne));

            // Find the larger number between numberOne and numberTwo
            Console.WriteLine(Math.Max(numberOne, numberTwo));
            
             
             
             
            // First string variable
            string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
            // Second string variable
            string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";

            // Print variable and newline
            Console.WriteLine(firstSentence);
            Console.WriteLine("\n");
            Console.WriteLine(firstSpeech);
            
             
            // Declare the variables
            string beginning = "Once upon a time";
            string middle = "the kid climbed a tree";
            string end = "Everyone lived happily ever after";

            // Concatenate the string and the variables
            string story = beginning + ", " + middle + ". " + end + ".";

            // Print the story to the console 
            Console.WriteLine(story);
            
             
            // Declare the variables
            string beginning = "Once upon a time,";
            string middle = "The kid climbed a tree";
            string end = "Everyone lived happily ever after.";
            
             
            // Create password
            string password = "a92301j2add";

            // Get password length
            int passwordLength = password.Length;

            // Check if password uses symbol
            int passwordCheck = password.IndexOf("!");

            // Print results
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.");
            
             
            // dna strand
            string startStrand = "ATGCGATGAGCTTAC";

            // find location of "tga"
            int tga = startStrand.IndexOf("TGA");

            // start point and stop point variables
            int startPoint = 0;
            int length = tga + 3;

            // define final strand
            string dna = startStrand.Substring(startPoint, length);
            Console.WriteLine(dna);

            // DNA mutation search
            Console.WriteLine(dna[3]);
            
             
            // Script line
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

            // Get camera directions
            int charPosition = script.IndexOf("Close");
            int length = "Close on".Length;
            string cameraDirections = script.Substring(charPosition, length);

            // Get scene description
            charPosition = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(charPosition);

            // Make camera directions uppercase
            cameraDirections = cameraDirections.ToUpper();

            // Make scene description lowercase
            sceneDescription = sceneDescription.ToLower();

            // Print results
            Console.WriteLine($"{cameraDirections} {sceneDescription}");*/
        }
    }
}
