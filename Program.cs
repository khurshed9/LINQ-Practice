using Practice.DataContext;
using Practice.Entities;

Console.Read();

DataContext context = new DataContext();

//1
/*var t1 = from c in context.Categories
    join p in context.Products on c.Id equals p.CategoryId
    group p by c into g
    select new
    {
        Category = g.Key.Name,
        Product = g.ToList()
    };

foreach (var q1 in t1)
{
    Console.WriteLine($"Category: {q1.Category}");
        foreach (var product in q1.Product)
        {
            Console.WriteLine("\t" + product.Name);
        }
}*/

//2
/*var t2 = from u in context.Users
    join o in context.Orders on u.Id equals o.UserId
    where  u.Id == 3
    group o by u into g
    select new
    {
        UserName = g.Key.Username,
        Order = g.Sum(o=>o.TotalAmount)
    };

foreach (var q2 in t2)
{
    Console.WriteLine($"UserName: {q2.UserName}, Order: {q2.Order}");
}*/

//3
/*var t2 = from p in context.Products
    join c in context.Categories on p.CategoryId equals c.Id
    group p by c into g
    select new
    {
        Category = g.Key.Name,
        TotalAmount = g.Count()
    };

foreach (var q2 in t2)
{
    Console.WriteLine(q2.Category + " " + q2.TotalAmount);
}*/

//4
/*var t4 = from u in context.Users
    join o in context.Orders on u.Id equals o.UserId
    group o by u into g
    select new
    {
        UserName = g.Key.Username,
        TotalOrders = g.Count(),
        TotalAmount = g.Sum(o=>o.TotalAmount)
    };

foreach (var q4 in t4)
{
    Console.WriteLine(q4.UserName + " " + q4.TotalOrders + " " + q4.TotalAmount);
}*/

//5
/*var t5 = from u in context.Users
    join o in context.Orders on u.Id equals o.UserId
    join or in context.OrderItems on o.Id equals or.OrderId
    join p in context.Products on or.ProductId equals p.Id
    join c in context.Categories on p.CategoryId equals c.Id
    where  o.TotalAmount > 400
    select new
    {
        UserName = u.Username,
        Order = o.TotalAmount,
        OrderItems = o.TotalAmount,
        ProductName = p.Name,
        Category = c.Name
    };

foreach (var q5 in t5)
{
    Console.WriteLine(q5.UserName + " " + q5.Order + " " + q5.OrderItems + " " + q5.ProductName + " " + q5.Category);
}*/

//6
/*var t6 = from p in context.Products
    where p.Stock > 20
    select p;

foreach (var q6 in t6)
{
    Console.WriteLine(q6.Name + " " + q6.Stock);
}*/

//7
/*var t7 = from o in context.Orders
    where o.OrderDate > DateTime.UtcNow.AddDays(-3)
    select o;

foreach (var q7 in t7)
{
    Console.WriteLine(q7.Id + " " + q7.TotalAmount + " " + q7.OrderDate);
}*/
    
    
//8
/*var t1 = from o in context.Orders
    join u in context.Users on o.UserId equals u.Id
    group o by u
    into g
    select new
    {
        User = g.Key.Username,
        TotalAmount = g.Sum(o => o.TotalAmount)
    };

foreach (var q1 in t1)
{
    Console.WriteLine(q1.User + " " + q1.TotalAmount);
}*/

//9
/*var t9 = from u in context.Users
    join o in context.Orders on u.Id equals o.UserId
    where o.TotalAmount > 200
    select new
    {
        Id = u.Id,
        Username = u.Username,
        TotalAmount = o.TotalAmount,
    };

foreach (var q9 in t9)
{
    Console.WriteLine(q9.Id + " " + q9.Username + " " + q9.TotalAmount);
}*/


//10
/*var t10 = from p in context.Products
          orderby p.Price
          select new
          {
              Id = p.Id,
              ProductName = p.Name,
              Price = p.Price,
              Stock = p.Stock
          };

foreach (var q10 in t10)
{
    Console.WriteLine(q10.Id + " " + q10.ProductName + " " + q10.Price + " " + q10.Stock);
}*/

//11
/*var t11 = from o in context.Orders
    join or in context.OrderItems on o.Id equals or.OrderId
    group or by o
    into g
    select new
    {
        OrderId = g.Key.Id,
        OrderItems = g.ToList()
    };

foreach (var q11 in t11)
{
    Console.WriteLine($"OrderId: {q11.OrderId}");
    foreach (var qq11 in q11.OrderItems)
    {
        Console.WriteLine("\t" + qq11.Price);
    }
}*/


//12
/*var t12 = from p in context.Products
    select new
    {
        CategoryName = p.Name,
        Description = p.Description
    };

foreach (var q12 in t12)
{
    Console.WriteLine(q12.CategoryName + ": " + q12.Description);
}*/


//13
/*var t13 = from u in context.Users
    join o in context.Orders on u.Id equals o.UserId
    select u;

foreach (var q13 in t13)
{
    Console.WriteLine(q13.Id + " " + q13.Username + " " + q13.Email);
}*/

//14
//Получить все товары в конкретной категории, чтобы сосредоточиться на определенном сегменте товаров.

Console.WriteLine("---------------------------------------------------------");


//15
/*var t15 = from o in context.Orders
    join or in context.OrderItems on o.Id equals or.OrderId
    join p in context.Products on or.ProductId equals p.Id
    where p.Name == "Smartphone"
    group o by p into g
    select new
    {
        ProductName = g.Key.Name,
        Orders = g.ToList()
    };

foreach (var q15 in t15)
{
    Console.WriteLine(q15.ProductName);
    foreach (var qq15 in q15.Orders)
    {
        Console.WriteLine(qq15.TotalAmount + " " + qq15.OrderDate);
    }
}*/


//16
/*
var t16 = from o in context.Orders
    join u in context.Users on o.UserId equals u.Id
    group o by u into g
        select new
        {
            UserId = g.Key.Id,
            Username = g.Key.Username,
            LastOrder = g.FirstOrDefault()
        };

foreach (var q16 in t16)
{
    Console.WriteLine(q16.UserId + " " + q16.Username + " " + q16.LastOrder.TotalAmount + " " + q16.LastOrder.OrderDate);
}*/


//17
/*var t17 = context.Products.Count();
Console.WriteLine(t17);*/

//18
/*
var t18 = from o in context.Orders 
    group o by o into g
    select new
    {
        OrderId = g.Key.Id,
        OrderDate = g.Key.OrderDate,
        TotalAmount = g.Sum(o => o.TotalAmount)
    };

foreach (var q18 in t18)
{
    Console.WriteLine(q18.OrderId + " " + q18.OrderDate + " " + q18.TotalAmount);
}*/


//19
/*var t19 = from p in context.Products
           where p.IsDeleted == true
           select p;

foreach (var q19 in t19)
{
    Console.WriteLine(q19.Id + " " + q19.Name + " " + q19.Description);
}*/

//20
/*var t20 = from u in context.Users
    join o in context.Orders on u.Id equals o.UserId into userOrders
    from o in userOrders.DefaultIfEmpty()
    where o == null
    select u;

foreach (var q20 in t20)
{
    Console.WriteLine(q20.Id + " " + q20.Username + " " + q20.Email);
}*/


//21
/*var threeMonthsAgo = DateTime.UtcNow.AddMonths(-3);
var t21 = from p in context.Products
          where p.CreatedAt <= threeMonthsAgo && p.Stock > 0
          select p;

foreach (var q21 in t21)
{
    Console.WriteLine(q21.Id + " " + q21.Name + " " + q21.Description + " " + q21.CreatedAt + " " + q21.Stock);
}*/

//22
/*var t22 = from u in context.Users
    join o in context.Orders on u.Id equals o.UserId
    join or in context.OrderItems on o.Id equals or.OrderId
    join p in context.Products on or.ProductId equals p.Id
    group p by u into g
    select new
    {
        UserId = g.Key.Id,
        UserName = g.Key.Username,
        TotalUniqueProducts = g.Distinct().Count()
    };

foreach (var q22 in t22)
{
    Console.WriteLine(q22.UserId + " " + q22.UserName + " " + q22.TotalUniqueProducts);
}*/

//23
 /*var t23 = from o in context.Orders
 where o.CreatedAt > DateTime.UtcNow.AddYears(-1)
 group o.CreatedAt.Month by o into g
     select new
     {
         Order = g.Key,
         OrderCount = g.Count()
     };
 foreach (var o in t23)
 {
     Console.WriteLine(o.Order.OrderDate+" "+o.OrderCount);
 }*/

//24 
/*var t24 = from o in context.Orders
    join or in context.OrderItems on o.Id equals or.OrderId
     select new
    {
        OrderId = o.Id,
        Quantity = or.Quantity
    };

foreach (var q24 in t24)
{
    Console.WriteLine(q24.OrderId + " " + q24.Quantity);
}*/

//25
/*var t25 = from c in context.Categories
 join p in context.Products on c.Id equals p.CategoryId
 join oi in context.OrderItems on p.Id equals oi.ProductId
 group new { p, oi } by c.Name into g
 select new
 {
     CategoryName = g.Key,
     Total = g.Sum(x => x.p.Price * x.oi.Quantity)
 };
 var top = t25.OrderByDescending(x=>x.Total).FirstOrDefault();
 Console.WriteLine(top?.CategoryName+"  "+top?.Total);*/

//26
 /*var t26 = from u in context.Users
 join o in context.Orders on u.Id equals o.UserId
 join oi in context.OrderItems on o.Id equals oi.OrderId 
 join p in context.Products on oi.ProductId equals p.Id
 where p.Name == "Smartphone"
 select u.Username;
 foreach (var u in t26)
 {
     Console.WriteLine(u);
 }*/

//27
 /*var t27 = from u in context.Users
     join o in context.Orders on u.Id equals o.UserId
     where o.TotalAmount > 300 && o.OrderDate > DateTime.UtcNow.AddYears(-1)
     select u.Username;
 foreach (var u in t27)
 {
     Console.WriteLine(u);
 }*/

//28
 /*var t28 = from u in context.Users
     where u.CreatedAt>DateTime.UtcNow.AddMonths(-1)
     select u.Username;
 foreach (var u in t28)
 {
     Console.WriteLine(u);
 }*/

//30
/*var products = from order in context.Orders
                join orderItem in context.OrderItems on order.Id equals orderItem.OrderId
                join product in context.Products on orderItem.ProductId equals product.Id
                group order by product into productOrders 
                where productOrders.Count()>=10
                select new
                {
                    Product = productOrders.Key.Name,
                    OrderCount = productOrders.Count()
                };
foreach (var i in products) 
{
     Console.WriteLine(i.Product+" "+i.OrderCount);
}*/