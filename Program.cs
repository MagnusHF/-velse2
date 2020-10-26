using System;

namespace Repitation_8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // My strings and bool.
            string fName;
            string lName;
            string Address;
            string PhoneNumber;
            string yes = "j";
            bool newround = false;

            // This is the beginning of the loop. 
            do
            {
                // This is where the user fills in their information. 
                Console.Write("Indtast dit første navn -> ");
                fName = Console.ReadLine();
                Console.Write("Indtast dit efternavn -> ");
                lName = Console.ReadLine(); 
                Console.Write("Indtast din adresse -> ");
                Address = Console.ReadLine();
                Console.Write("Indtast dit telefonnummmer -> ");
                PhoneNumber = Console.ReadLine();

                // These are my links to my methods.
                SetStarsFullName();
                OutputFullName(fName, lName);
                SetStarsAddress();
                OutputAddress(Address);
                OutputPhoneNumber(PhoneNumber);

                // This makes sure that it asks the user if they want to run the code again.
                Console.WriteLine("Vil du køre programmet igen? Indtast [j/n] -> ");
                string answer = Console.ReadLine();

                // Here it makes it so that if you type "j" it runs the code again.
                if (answer == "j")
                {
                    newround = true;
                    Console.Clear();
                }
                // This makes it so that if you answer something else, in this case "n", it will end the code.
                else
                {
                    newround = false;
                }
                // And this is what stops the loop.
            } while (newround == true);
            Console.ReadKey();
        }
        // This is what makes it so that the last name comes before the first.
        static void OutputFullName(string fName, string lName)
        {
            Console.WriteLine(lName + " " + fName);
        }
        static void OutputAddress(string Address)
        {
            Console.WriteLine(Address);
        }
        static string OutputPhoneNumber(string PhoneNumber)
        {
            // Here I am making substrings while also setting the cursor positions.
            Console.SetCursorPosition(55, 12);
            string FirstTwoDigits = PhoneNumber.Substring(0, 2);
            string SecondTwoDigits = PhoneNumber.Substring(2, 2);
            string NextTwoDigits = PhoneNumber.Substring(4, 2);
            string LastTwoDigits = PhoneNumber.Substring(6, 2);
            Console.WriteLine(FirstTwoDigits + " " + SecondTwoDigits + " " + NextTwoDigits + " " + LastTwoDigits);
            return PhoneNumber;
        }
        // This is what sets the cursor position for both fullname and address.
        static void SetStarsFullName()
        {
            Console.SetCursorPosition(55, 10);
        }
        static void SetStarsAddress()
        {
            Console.SetCursorPosition(55, 11);
        }
    }
}