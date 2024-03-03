// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

BankAccount _one = new BankAccount("1", "Luke B", 10000);
BankAccount _two = new BankAccount("2", "Sauv G", 1);
_one.deposit(99990000);
_one.DisplayInfomation();
_two.DisplayInfomation();


Console.ReadLine();
public class BankAccount
{
    private string _id;
    private string _name;
    private double _balance;


    public BankAccount(string id, string name, double balance)
    {
        _id = id;
        _name = name;
        _balance = balance;
    }

    public void deposit(double amount)
    {
        _balance += amount;
    }
    public void withdraw(double amount)
    {
        if (amount <= 0)
        {
            _balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }
    public void GetBalance()
    {
        Console.WriteLine($"User {_id} your balance is £{_balance}");
    }
    public void DisplayInfomation()
    {
        Console.WriteLine($"User {_id} {_name} your balance is £{_balance}");
    }

    internal void deposit()
    {
        throw new NotImplementedException();
    }
}
