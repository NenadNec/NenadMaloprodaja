using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maloprodaja.Klase
{
    public class InvoiceRequest
    {
		public string dateAndTimeOfIssue { get; set; }
		public string cashier { get; set; }
		public string buyerId { get; set; }
		public string buyerCostCenterId { get; set; }
		public InvoiceType invoiceType { get; set; }
		public TransactionType transactionType { get; set; }
		public string referentDocumentNumber { get; set; }
		public string referentDocumentDT { get; set; }
		public List<Payment> payment { get; set; }
		public string invoiceNumber { get; set; }
		public Options options { get; set; }
		public List<InvoiceItem> items { get; set; }


		public enum InvoiceType
		{
			Normal,

			Zero = 0,

			Proforma,

			One = 1,

			Copy,

			Two = 2,

			Training,

			Three = 3,

			Advance,

			Four = 4
		}

		public enum TransactionType
		{

			Sale,

			Zero = 0,

			Refund,

			One = 1
		}
		public class InvoiceItem
		{
			public string GTIN { get; set; }
			public string name { get; set; }
			public double quantity { get; set; }
			public double unitPrice { get; set; }
			public string[] labels { get; set; }
			public double totalAmount { get; set; }
		}
		public class Options
		{
			public string OmitQRCodeGen { get; set; }
			public string OmitTextualRepresentation { get; set; }
		}
		public enum OptionsValues : byte
		{
			Zero,
			One
		}

		public class Payment
		{
			public double amount { get; set; }
			public Payment.PaymentType? paymentType { get; set; }
			public enum PaymentType
			{

				Other,
				Zero = 0,
				Cash,
				One = 1,
				Card,
				Two = 2,
				Check,
				Three = 3,
				WireTransfer,
				Four = 4,
				Voucher,
				Five = 5,
				MobileMoney,
				Six = 6
			}
		}
	}
}
