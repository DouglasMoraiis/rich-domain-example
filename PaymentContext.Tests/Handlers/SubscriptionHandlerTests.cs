using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
    [TestClass]
    public class SubscriptionHandlerTests 
    {
        // Red, Green, Refactor

        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();

            command.LastName = "Jander";
            command.FirstName = "Morais";
            command.Document = "99999999999";
            command.Email = "jander@gmail.com";
            command.BarCode = "123456789";
            command.BoletoNumber = "12345689";
            command.PaymentNumber = "123122";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Payer = "Witcher";
            command.PayerEmail = "witcher@fitbank.com";
            command.PayerDocument = "12345670340";
            command.PayerDocumentType = EDocumentType.CNPJ;
            command.Total = 60;
            command.TotalPaid = 60;
            command.Street = "Avenida Joao";
            command.Number = "1234";
            command.Neighborhood = "Bairro Grande";
            command.City = "Horizon";
            command.State = "CE";
            command.Country = "BRA";
            command.ZipCode = "62900000";

            handler.Handle(command);
            Assert.AreEqual(false, handler.IsValid);
        }
       
    }
}