namespace Funds_Installment
{
    internal class Application
    {
        public void Run()
        {
            MainMenu();
            var selectedProduct = SelectProduct();
            var date = GetDate(out int paymentPlan);

            switch (paymentPlan)
            {
                case 1:
                    CalculatePercentage(selectedProduct.amount, 2, date);
                    break;
                case 2:
                    CalculatePercentage(selectedProduct.amount, 5, date);
                    break;  
                case 3:
                    CalculatePercentage(selectedProduct.amount, 10, date);
                    break;  
                case 4:
                    CalculatePercentage(selectedProduct.amount, 20, date);
                    break; 
                case 5:
                    CalculatePercentage(selectedProduct.amount, 25, date);
                    break; 
                case 6:
                    CalculatePercentage(selectedProduct.amount, 50, date);
                    break;
                default:
                    Console.WriteLine("Invalid Input, try again");
                    break;
                    //Add invalid input code
                    //pass the switch statement into a method
                    //Handle magic strings
                    //Handle Errors
                    
            }
            CalculatePercentage(selectedProduct.amount, selectedProduct.selectedProduct,date);
        }


        public static void MainMenu()
        {
            Console.WriteLine("Hello, Welcome to Bubu's Business Ventures!\n");
            Console.WriteLine("Here's a list of our products : \n");
            Console.WriteLine("Kindly make your selection : \n");
            Console.WriteLine("1. Cows N50,000\n2. Sheep N20,000\n3. Goats N10,000\n4. Chicken N5,000 ");

        }
        static int CollectPaymentPlan()
        {
            Console.WriteLine("1. 2% for daily Payment\n2. 5% for Weekly Payment\n3. 10% for Bi-Weekly\n4. 20% for Monthly Payment\n5. 25% for 6months\n6. 50% for 1year Payment");
            Console.WriteLine("Kindly enter your desired payment plan");
            return Convert.ToInt32(Console.ReadLine());

        }

        public static void CalculatePercentage(decimal totalAmount, decimal percent, DateTime newDate)
        {
            decimal amount =  percent / 100 * totalAmount;
          
          
           decimal installments = totalAmount / amount;
           Console.WriteLine(installments);
           Console.WriteLine($"{percent}% of N{totalAmount} is N{amount}, so you will pay N{amount} weekly in {installments} installments to complete payment");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your deadline to complete payment will be: " + newDate);
            Console.ResetColor();
            Console.WriteLine("Do you want to run another transaction? \nY or N");
            var response = Console.ReadLine().ToUpper();
            if (response == "Y")
            {
                MainMenu();
            }
            else if (response == "N")
            {
                Environment.Exit(10);
            }
        }
        public static void HandlePaymentPlan()
        {
            SelectProduct();
            CollectPaymentPlan();
            //Collect Selected Rproduct
            //Collect Payment Plan
        }

        public static DateTime GetDate(out int paymentPlan)
        {
        returnHere:
            var plan = CollectPaymentPlan();
            paymentPlan = plan;
            switch (plan)
            {
                case 1:

                    return DateTime.Now.AddDays(50);
                case 2:
                    return DateTime.Now.AddDays(140);
                case 3:
                    return DateTime.Now.AddDays(70);
                case 4:
                    return DateTime.Now.AddMonths(5);
                case 5:
                    return DateTime.Now.AddMonths(4);
                case 6:
                    return DateTime.Now.AddYears(2);
                default:
                    Console.WriteLine("Invalid Input, try again");
                    break;
            }
            goto returnHere;
        }

        enum PaymentPlan
        {
            DAILY,
            WEEKLY,
            BIWEEKLY,
            MONTHLY,
            SIXMONTHS,
            YEARLY
        }

        public static void ProductAnnouncer(string productName, string amount)
        {
            Console.WriteLine($"A {productName} costs N{amount}\nKindly select a payment plan suitable for you\n");
        }

        public static (int selectedProduct, decimal amount, string productName) SelectProduct()
        {
        start:
            var selectedProduct = Convert.ToInt32(Console.ReadLine());
            switch (selectedProduct)
            {
                case 1:
                    ProductAnnouncer("Cow", "50,000");
                    return (1, 50000, "Cow");
                case 2:
                    ProductAnnouncer("Sheep", "20,000");
                    return (2, 20000, "Sheep");
                case 3:
                    ProductAnnouncer("Goat", "10,000");
                    return (3, 10000, "Goat");
                case 4:
                    ProductAnnouncer("Chicken", "5,000");
                    return (4, 5000, "Chicken");
                default:
                    Console.WriteLine("Invalid Input, try again");
                    goto start;
            }
        }
    }
}
