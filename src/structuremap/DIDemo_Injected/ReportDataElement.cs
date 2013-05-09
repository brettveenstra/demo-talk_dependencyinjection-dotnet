using System;

namespace DIDemo_Injected
{
  public class ReportDataElement
  {
    public ReportDataElement(DateTime orderDate, int orderId, double orderAmount)
    {
      this.OrderDate = orderDate;
      this.OrderId = orderId;
      this.OrderAmount = orderAmount;
    }

    public DateTime OrderDate { get; private set; }

    public int OrderId { get; private set; }

    public double OrderAmount { get; private set; }
  }
}