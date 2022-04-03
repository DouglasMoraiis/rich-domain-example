using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests;

[TestClass]
public class CreateBoletoSubscriptionCommandTests
{
    // RED, GREEN, REFACTOR
    [TestMethod]
    public void ShouldReturnErrorWhenNameIsInValid()
    {
        var command = new CreateBoletoSubscriptionCommand();
        command.FirstName = "";

        command.Validate();
        Assert.AreEqual(false, command.IsValid);
    }
}