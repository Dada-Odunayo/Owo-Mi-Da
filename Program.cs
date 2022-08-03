namespace Owo_Da
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OWO DA App");
            Console.WriteLine("You will need to respond to a number of questions for your ticket to be generated");
            var cus1 = new OwoDa();
            Console.WriteLine(cus1.CalculateAmount());
            

        }
    }

    public class OwoDa
    {
        public  string CalculateAmount()
        {
            float total = 0;
            int busFee = 500, miniBusFee = 400, tricycleFee = 300, motorcycleFee = 100;
            float discount = 0.7f;
            float amount =0;
            for (int i = 0; i < 5; i++)
            {               
                Console.WriteLine(i+1+" Are you a union member? - Respond with yes or no ");
                string member = Console.ReadLine();

                Console.WriteLine("What is the total number of trips taken?");
                int tripNo = int.Parse(Console.ReadLine());

                Console.WriteLine("What type of vehicle do you drive?\nEnter the number specified\n1. Bus" +
                    "\n2. Mini Bus\n3. Tricycle\n4. Motorcycle ");
                int vehicleType = int.Parse(Console.ReadLine());

                if (vehicleType == 1 && member == "yes")
                {
                    amount = discount * busFee * tripNo;
                    total += amount;
                }
                else if (vehicleType == 1 && member == "no")
                {
                    amount = busFee * tripNo;
                     total += amount;
                }
                else if (vehicleType == 2 && member == "yes")
                {
                    amount = discount * miniBusFee * tripNo;
                     total += amount;
                }
                if (vehicleType == 2 && member == "no")
                {
                    amount = miniBusFee * tripNo;
                    total += amount;
                }
                else if (vehicleType == 3 && member == "yes")
                {
                    amount = discount * tricycleFee * tripNo;
                     total += amount;
                }
                else if (vehicleType == 3 && member == "no")
                {
                    amount = tricycleFee * tripNo;
                     total += amount;
                }
                else if (vehicleType == 4 && member == "yes")
                {
                    amount = discount * motorcycleFee * tripNo;
                     total += amount;
                }
                else if (vehicleType == 4 && member == "no")
                {
                    amount = motorcycleFee * tripNo;
                    total += amount;
                }

               
            }
            return "The total fee you are to pay is "+total;

        }
        
    }

}