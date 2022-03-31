using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(
            DateTime paidDate,
            DateTime expireDate,
            string payer,
            Document document,
            decimal total,
            decimal totalPaid,
            string address,
            Email email,
            string cardHolderName,
            string cardNumber,
            string lastTransactionNumber) : base(
                paidDate,
                expireDate,
                payer,
                document,
                total,
                totalPaid,
                address,
                email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
    }

}