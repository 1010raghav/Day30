using NUnit.Framework;
using CabInvoiceGenerator;


namespace TestProject1
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;
        [Test]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);
        }
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] ride = { new Ride(2.0, 5), new Ride(0.1, 1) };
            InvoiceSummary invoiceSummary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0);

            Assert.AreEqual(expectedSummary, invoiceSummary);
        }
    }
}
