
using Enum1.Entities;
using Enum1.Entities.Enums;

Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendiPayment
};

Console.WriteLine(order);
string txt= OrderStatus.PendiPayment.ToString();

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
Console.WriteLine(os);