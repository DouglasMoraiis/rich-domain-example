using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests;

[TestClass]
public class DocumentTests
{
    // RED, GREEN, REFACTOR
    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsInValid()
    {
        var doc = new Document("123", EDocumentType.CNPJ);
        Assert.IsTrue(!doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnSucessWhenCNPJIsValid()
    {
        var doc = new Document("66617886000125", EDocumentType.CNPJ);
        Assert.IsTrue(doc.IsValid);
    }

    [TestMethod]
    [DataTestMethod]
    [DataRow("12312312")]
    [DataRow("12313")]
    [DataRow("000000000000000")]
    public void ShouldReturnErrorWhenCPFIsInValid(string cpf)
    {
        var doc = new Document(cpf, EDocumentType.CPF);
        Assert.IsTrue(!doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnSucessWhenCPFIsValid()
    {
        var doc = new Document("07888149356", EDocumentType.CPF);
        Assert.IsTrue(doc.IsValid);
    }
}