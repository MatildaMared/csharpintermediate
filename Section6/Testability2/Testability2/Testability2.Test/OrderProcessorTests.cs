using System;
using NUnit.Framework;

namespace Testability2.Test;

public class OrderProcessorTests
{
    [SetUp]
    public void Setup()
    {
    }

    // METHODNAME_CONDITION_EXPECTATION
    [Test]
    public void Process_OrderIsAlreadyShipped_ThrowsAnException()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order
        {
            Shipment = new Shipment()
        };
        orderProcessor.Process(order);
        Assert.Throws(InvalidOperationException, () => orderProcessor.Process(order));
    }
}

public class FakeShippingCalculator : IShippingCalculator
{
    public float CalculateShipping(Order order)
    {
        return 1;
    }
}