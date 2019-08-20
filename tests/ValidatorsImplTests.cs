using Checking;
using EasyEncrypt;
using Xunit;

namespace Tests
{
  public class ValidatorsImplTests
  {
    private CustomValidators validators;

    public ValidatorsImplTests()
    {
      this.validators = new ValidatorsImpl();
    }

    [Fact]
    public void should_contain_PositiveIntegerValidator()
    {
      Assert.IsAssignableFrom<PositiveIntegerValidator>(this.validators[typeof(int)]);
    }

    [Fact]
    public void should_supply_StringValidator()
    {
      Assert.IsAssignableFrom<StringValidator>(this.validators[typeof(string)]);
    }    
  }
}