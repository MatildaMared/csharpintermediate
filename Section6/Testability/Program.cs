var orderProcessor = new OrderProcessor();
var order = new Order {DatePlaced = DateTime.Now, TotalPrice = 100.0};
orderProcessor.Process(order);

