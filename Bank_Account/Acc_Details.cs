using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    public class Acc_Details
    {
        public long Account_Number { get; set; }
        public string Acc_opening_date { get; set; }
        public double Balance_Ammount { get; set; }
       // public double Credit { get; set; }

        public virtual double Debit(double Withdraw_Amt)
        {
            return Withdraw_Amt;

        }
        
    }
    //Creating class for Account Holder Name
    public class Acc_Hldr_Name
    {
        public List<string> myList = new List<string>() { "Maahi", "Mahesh" };
    }

    //Creating class for Savings Account
    public class Savings_Acc : Acc_Details
    {
        public override double Debit(double Withdraw_Amt)
        {

            return (Withdraw_Amt + (Withdraw_Amt * 0.1));

        }
    }

    //Creating class for Checking Account
    public class Checking_Acc : Acc_Details
    {
        public override double Debit(double Withdraw_Amt)
        {
            return (Withdraw_Amt + (Withdraw_Amt * 0.25));
        }

    }
    public class List_of_transactions
    {
        public List<double> lot = new List<double>();
    }
}
