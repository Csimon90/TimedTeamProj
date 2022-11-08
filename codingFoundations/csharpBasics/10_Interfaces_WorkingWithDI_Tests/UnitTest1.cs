using Xunit;

namespace Interfaces_WorkingWithDI_Tests;
public class TransactionTests
{
    private decimal _debt;

    public  TransactionTests()
    {
        _debt = 2000m;
    }

    private void PayDebt(ICurrency payment)
    {
        _debt -= payment.Value;
        System.Console.WriteLine($"You have paid {payment.Value:c} towards your debt.");
    }

    [Fact]
    public void PayDebt()
    {
        PayDebt(new Dollar());
        PayDebt(new ElectronicPayment(315.52m));

        decimal expectedAmount = 900.01m-316.52m; //we are accounting for the dollar subtraction above.

        Assert.Equal(expectedAmount,_debt);
    }
}
