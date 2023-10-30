using System;

public class BankAccount
{
    private string number;
    private string nameOfPerson;
    private decimal balance;

    public BankAccount(string number, string nameOfPerson, decimal initialBalance)
    {
        this.number = number;
        this.nameOfPerson = nameOfPerson;
        this.balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited ${amount} and your new balance is ${balance}");
        }
        else
        {
            Console.WriteLine("Negative number? Hello?");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn ${amount} and your new balance is ${balance}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("How do you plan to withdraw a negative amount of money?");
            }
            else
            {
                Console.WriteLine("No withdrawal for you :(");
            }
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Account Number: {number}");
        Console.WriteLine($"Account Holder: {nameOfPerson}");
        Console.WriteLine($"Current Balance: ${balance}");
    }
}