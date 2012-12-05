using System;

namespace DIDemo
{
  public class ReportDataElement
  {
    private readonly double _orderAmount;
    private readonly DateTime _orderDate;
    private readonly int _orderId;

    public ReportDataElement(DateTime orderDate, int orderId, double orderAmount)
    {
      _orderDate = orderDate;
      _orderId = orderId;
      _orderAmount = orderAmount;
    }

    public DateTime OrderDate
    {
      get { return _orderDate; }
    }

    public int OrderId
    {
      get { return _orderId; }
    }

    public double OrderAmount
    {
      get { return _orderAmount; }
    }
  }
}