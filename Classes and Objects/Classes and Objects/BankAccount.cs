using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes;


//Defining the Bank Account Type
public class BankAccount
{
    private static int s_accountNumberSeed = 1234567890;
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }

    public BankAccount(string name, decimal initialBalance)
    {
        //this.Owner = name;
        //this.Balance = initialBalance;
        // The this qualifier is only required when a local variable or parameter has the same name as that field or property. 

        Owner = name;
        Balance = initialBalance;
        Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;

        //The accountNumberSeed is a private static field and thus has the s_ prefix as per C# naming conventions.
        //The s denoting static and _ denoting private field.
    }
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
    }
}
