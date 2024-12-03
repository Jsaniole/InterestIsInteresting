//Each year, the balance of your savings account is updated based on its interest rate. The interest rate your bank gives you depends on
//the amount of money in your account (its balance):
//3.213% for a negative balance (balance gets more negative).
//0.5% for a positive balance less than 1000 dollars.
//1.621% for a positive balance greater than or equal to 1000 dollars and less than 5000 dollars.
//2.475% for a positive balance greater than or equal to 5000 dollars.

using System;

static class SavingsAccount
{
    //Task 1-- Calculate the interest rates
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
        {
            return 3.213f;
        }
        else if (balance >= 0 && balance < 1000)
        {
            return 0.5f;
        }
        else if (balance >= 1000 && balance < 5000)
        {
            return 1.621f;
        }
        else // balance >= 5000
        {
            return 2.475f;
        }
    }


    // Task 2-- Calculate the interest
    public static decimal Interest(decimal balance) => (decimal)(InterestRate(balance) / 100) * balance;


    //Task 3-- Calculate the annual balance update
    public static decimal AnnualBalanceUpdate(decimal balance) => Interest(balance) + balance;


    //Task 2-- calculate the years before reaching the desired balance
    // (target balance -  balance)/interest
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int count = 0;
        while (balance < targetBalance)
        {
            balance = (decimal)AnnualBalanceUpdate(balance);
            count++;
        }
        return count;
        throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");

    }
}
