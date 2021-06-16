using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Acc_Details ob1 = new Acc_Details();
            ob1.Account_Number = 74062832277435;
            ob1.Acc_opening_date = "03/02/1996";
            Console.WriteLine("Account Number : " + ob1.Account_Number);
            Console.WriteLine("Account Opening Date : " + ob1.Acc_opening_date);

            //Account holder name
            Acc_Hldr_Name obj = new Acc_Hldr_Name();
            Console.WriteLine("Name1 : " + obj.myList[0]);
            Console.WriteLine("Name2 : " + obj.myList[1]);

            //List of transactions
            List_of_transactions obj4 = new List_of_transactions();//creating object for List of transactions

            for (int i = 1; i <= 6; i++)
            {

                Console.WriteLine("Enter you options : 1.Savings Accopunt, 2.Checking Account");
                int option = Convert.ToInt32(Console.ReadLine());
                //Savings

                if (option == 1)
                {
                    Console.WriteLine("Enter the amount to withdraw from Savings Account : ");
                    Savings_Acc ob2 = new Savings_Acc();
                    int Amt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("transaction Debited Amount : " + ob2.Debit(Amt));
                    double Store = ob2.Debit(Amt);
                    obj4.lot.Add(Store);
                }
                else if (option == 2)
                {
                    //Checkings
                    Console.WriteLine("Enter the amount to withdraw from Checking Account : ");
                    Checking_Acc ob3 = new Checking_Acc();
                    int Amt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("transaction Debited Amount : " + ob3.Debit(Amt));
                    double Store = ob3.Debit(Amt);
                    obj4.lot.Add(Store);
                }
            }
            //to print Last 5 Transactions
            for (int k = 1; k < 6; k++)
            {
                Console.WriteLine(k + "." + "Transaction amout : " + obj4.lot[k]);
            }

        }
    }
    
}
