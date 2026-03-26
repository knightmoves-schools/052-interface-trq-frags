namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Define_A_Public_Interface_Named_Deliverable(){
      Deliverable deliverable = new Mail();
      Assert.NotNull(deliverable);
    }

    [Fact]
    public void Should_Contain_A_Method_Definition_Named_Deliver_That_Takes_A_String_Named_Address_And_Return_A_Boolean(){
       Deliverable deliverable = new Mail();
       Assert.True(deliverable.Deliver("test"));
    }
}

public class Mail : Deliverable
{
    public bool Deliver(string address)
    {
        return true;
    }
}