namespace Funds_Installment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int days = 0;
            int cowPrice = 50000;
            int sheepPrice = 20000;
            int goatPrice = 10000;
            int chickenPrice = 5000;
            int paymentPlan;
            try
            {
                Console.WriteLine("Hello, Welcome to Bubu's Business Ventures!\n");
                Console.WriteLine("Here's a list of our products : \n");
                Console.WriteLine("Kindly make your selection : \n");
                Console.WriteLine("1. Cows N50,000\n2. Sheep N20,000\n3. Goats N10,000\n4. Chicken N5,000 ");

                var selectedProduct = Convert.ToInt32(Console.ReadLine());
                if (selectedProduct == 1)
                {
                    Console.WriteLine("A Cow costs N50,000\nKindly select a payment plan suitable for you\n");
                    Console.WriteLine("1. 2% for daily Payment\n2. 5% for Weekly Payment\n3. 10% for Bi-Weekly\n4. 20% for Monthly Payment\n5. 25% for 6months\n6. 50% for 1year Payment");
                    Console.WriteLine("Kindly enter amount to pay");
                    paymentPlan = Convert.ToInt32(Console.ReadLine());

                    if (paymentPlan == 1)
                    {
                        DateTime newdate = DateTime.Now.AddDays(50);
                        Console.WriteLine("2% of N50000 is N1000, so you will pay N1,000 daily in 50 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("$ Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 2)
                    {
                        DateTime newdate = DateTime.Now.AddDays(140);
                        Console.WriteLine("5% of N50000 is N2,500, so you will pay N2,500 weekly in 20 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 3)
                    {
                        DateTime newdate = DateTime.Now.AddDays(70);
                        Console.WriteLine("10% of N50000 is N5,000, so you will pay N5,000 Bi-weekly in 10 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 4)
                    {
                        DateTime newdate = DateTime.Now.AddMonths(5);
                        Console.WriteLine("20% of N50000 is N10,000, so you will pay N10,000 Monthly in 5 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 5)
                    {
                        DateTime newdate = DateTime.Now.AddMonths(4);
                        Console.WriteLine("25% of N50000 is N12,500, so you will pay N12,500 in 4 installments after 6months to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 6)
                    {
                        DateTime newdate = DateTime.Now.AddYears(2);
                        Console.WriteLine("50% of N50000 is N25,000, so you will pay N25000 in 2 installments 1year to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry!!");
                    }
                }
                else if (selectedProduct == 2)
                {
                    Console.WriteLine("A Sheep costs N20,000\nKindly select a payment plan suitable for you");
                    Console.WriteLine("2% for daily Payment\n5% for Weekly Payment\n10% for Bi-Weekly\n20% for Monthly Payment\n25% for 6months\n50% for 1year Payment");
                    Console.WriteLine("Kindly enter amount to pay");
                    paymentPlan = Convert.ToInt32(Console.ReadLine());

                    if (paymentPlan == 1)
                    {
                        DateTime newdate = DateTime.Now.AddDays(50);
                        Console.WriteLine("2% of N20000 is N400, so you will pay N400 daily in 50 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("$ Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 2)
                    {
                        DateTime newdate = DateTime.Now.AddDays(140);
                        Console.WriteLine("5% of N20000 is N1000, so you will pay N1000 weekly in 20 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 3)
                    {
                        DateTime newdate = DateTime.Now.AddDays(70);
                        Console.WriteLine("10% of N20000 is N2,000, so you will pay N2,000 Bi-weekly in 10 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 4)
                    {
                        DateTime newdate = DateTime.Now.AddMonths(5);
                        Console.WriteLine("20% of N20000 is N4,000, so you will pay N4,000 Monthly in 5 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 5)
                    {
                        DateTime newdate = DateTime.Now.AddMonths(4);
                        Console.WriteLine("25% of N20,000 is N5,000, so you will pay N5,000 in 4 installments after 6months interval to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 6)
                    {
                        DateTime newdate = DateTime.Now.AddYears(2);
                        Console.WriteLine("50% of N20000 is N10,000, so you will pay N10,000 in 2 installments per year interval to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry!!");
                    }
                }
                else if (selectedProduct == 3)
                {
                    Console.WriteLine("A Goat costs N10,000\nKindly select a payment plan suitable for you");
                    Console.WriteLine("2% for daily Payment\n5% for Weekly Payment\n10% for Bi-Weekly\n20% for Monthly Payment\n25% for 6months\n50% for 1year Payment");
                    Console.WriteLine("Kindly enter amount to pay");
                    paymentPlan = Convert.ToInt32(Console.ReadLine());

                    if (paymentPlan == 1)
                    {
                        DateTime newdate = DateTime.Now.AddDays(50);
                        Console.WriteLine("2% of N10,000 is N200, so you will pay N200 daily in 50 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("$ Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 2)
                    {
                        DateTime newdate = DateTime.Now.AddDays(140);
                        Console.WriteLine("5% of N10,000 is N500, so you will pay N500 weekly in 20 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 3)
                    {
                        DateTime newdate = DateTime.Now.AddDays(70);
                        Console.WriteLine("10% of N10,000 is N1,000, so you will pay N1,000 Bi-weekly in 10 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 4)
                    {
                        DateTime newdate = DateTime.Now.AddMonths(5);
                        Console.WriteLine("20% of N10,000 is N2,000, so you will pay N2,000 Monthly in 5 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 5)
                    {
                        DateTime newdate = DateTime.Now.AddMonths(4);
                        Console.WriteLine("25% of N50000 is N2,500, so you will pay N2,500 in 4 installments after 6months interval to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 6)
                    {
                        DateTime newdate = DateTime.Now.AddYears(2);
                        Console.WriteLine("50% of N50000 is N10,000, so you will pay N10,000 in 2 installments per year to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry!!");
                    }
                }
                else if (selectedProduct == 4)
                {
                    Console.WriteLine("A Chicken costs N5,000\nKindly select a payment plan suitable for you");
                    Console.WriteLine("2% for daily Payment\n5% for Weekly Payment\n10% for Bi-Weekly\n20% for Monthly Payment\n25% for 6months\n50% for 1year Payment");
                    Console.WriteLine("Kindly enter amount to pay");
                    paymentPlan = Convert.ToInt32(Console.ReadLine());

                    if (paymentPlan == 1)
                    {
                        DateTime newdate = DateTime.Now.AddDays(50);
                        Console.WriteLine("2% of N5000 is N100, so you will pay N100 daily in 50 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("$ Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 2)
                    {
                        DateTime newdate = DateTime.Now.AddDays(140);
                        Console.WriteLine("5% of N50000 is N250, so you will pay N250 weekly in 20 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 3)
                    {
                        DateTime newdate = DateTime.Now.AddDays(70);
                        Console.WriteLine("10% of N50000 is N500, so you will pay N500 Bi-weekly in 10 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 4)
                    {
                        DateTime newdate = DateTime.Now.AddMonths(5);
                        Console.WriteLine("20% of N50000 is N1,000, so you will pay N1,000 Monthly in 5 installments to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 5)
                    {
                        DateTime newdate = DateTime.Now.AddMonths(4);
                        Console.WriteLine("25% of N50000 is N1250, so you will pay N1250 in 4 installments after 6months interval to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else if (paymentPlan == 6)
                    {
                        DateTime newdate = DateTime.Now.AddYears(2);
                        Console.WriteLine("50% of N50000 is N2,500 so you will pay N2,500 in 2 installments per year to complete payment");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Your deadline to complete payment will be: " + newdate);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry!!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Entry!!");
                }

            }catch(Exception ex)
            {
                Console.WriteLine("An Error Occured : " + ex.Message);
            }

        }
    }
}