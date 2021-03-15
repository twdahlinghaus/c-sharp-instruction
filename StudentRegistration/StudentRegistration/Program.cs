using System;

namespace StudentRegistration {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Student Registration!");

            Console.Write("Enter your first name: ");
            String fName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            String lName = Console.ReadLine();
            Console.Write("Enter your year of birth (YYYY format): ");
            String bYear = Console.ReadLine();
            String tempPassword = fName + "*" + bYear;
            Console.WriteLine("Welcome  "+ fName + " " + lName + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: "+ tempPassword);
                        
                Console.WriteLine("Bye!");
        }
    }
}
