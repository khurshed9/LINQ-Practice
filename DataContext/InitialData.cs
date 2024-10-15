using Practice.Entities;

namespace Practice.DataContext;

public static class InitialData
{
    public static IEnumerable<Category> Categories() => Data.Categories;
    public static IEnumerable<Product> Products() => Data.Products;
    public static IEnumerable<User> Users() => Data.Users;
    public static IEnumerable<Order> Orders() => Data.Orders;
    public static IEnumerable<OrderItem> OrderItems() => Data.OrderItems;
}

file static class Data
{
    public static readonly IEnumerable<Category> Categories = new List<Category>
    {
        new Category { Id = 1, Name = "Electronics", Description = "Devices and gadgets." },
        new Category { Id = 2, Name = "Books", Description = "All kinds of books." },
        new Category { Id = 3, Name = "Clothing", Description = "Fashionable apparel." },
        new Category { Id = 4, Name = "Toys", Description = "Children's toys." },
        new Category { Id = 5, Name = "Home Appliances", Description = "Appliances for home." },
        new Category { Id = 6, Name = "Sports", Description = "Sports equipment." },
        new Category { Id = 7, Name = "Health", Description = "Health-related products." },
        new Category { Id = 8, Name = "Beauty", Description = "Beauty products." },
        new Category { Id = 9, Name = "Furniture", Description = "Furniture for home." },
        new Category { Id = 10, Name = "Stationery", Description = "Office supplies." },
        new Category { Id = 11, Name = "Food", Description = "Groceries and food items." },
        new Category { Id = 12, Name = "Automotive", Description = "Car accessories." },
        new Category { Id = 13, Name = "Music", Description = "Music instruments and accessories." },
        new Category { Id = 14, Name = "Gardening", Description = "Gardening tools." },
        new Category { Id = 15, Name = "Travel", Description = "Travel-related products." },
        new Category { Id = 16, Name = "Pets", Description = "Pet supplies." },
        new Category { Id = 17, Name = "Watches", Description = "Timepieces." },
        new Category { Id = 18, Name = "Jewelry", Description = "Fashion jewelry." },
        new Category { Id = 19, Name = "Bags", Description = "Bags and backpacks." },
        new Category { Id = 20, Name = "Gadgets", Description = "Latest gadgets." }
    };

    public static readonly IEnumerable<Product> Products = new List<Product>
    {
        new Product
        {
            Id = 1, Name = "Smartphone", Description = "Latest model smartphone.", Price = 699.99m, Stock = 50,
            CategoryId = 1
        },
        new Product
        {
            Id = 2, Name = "Laptop", Description = "High-performance laptop.", Price = 1299.99m, Stock = 30,
            CategoryId = 1
        },
        new Product
        {
            Id = 3, Name = "Novel", Description = "Bestselling novel.", Price = 19.99m, Stock = 100, CategoryId = 2
        },
        new Product
        {
            Id = 4, Name = "T-Shirt", Description = "Cotton t-shirt.", Price = 15.99m, Stock = 200, CategoryId = 3
        },
        new Product
        {
            Id = 5, Name = "Action Figure", Description = "Popular action figure.", Price = 29.99m, Stock = 150,
            CategoryId = 4
        },
        new Product
        {
            Id = 6, Name = "Blender", Description = "High-speed blender.", Price = 89.99m, Stock = 80, CategoryId = 5
        },
        new Product
        {
            Id = 7, Name = "Soccer Ball", Description = "Standard soccer ball.", Price = 24.99m, Stock = 60,
            CategoryId = 6
        },
        new Product
        {
            Id = 8, Name = "Vitamin C", Description = "Vitamin C supplement.", Price = 14.99m, Stock = 120,
            CategoryId = 7
        },
        new Product
        {
            Id = 9, Name = "Lipstick", Description = "Red lipstick.", Price = 9.99m, Stock = 80, CategoryId = 8
        },
        new Product
        {
            Id = 10, Name = "Dining Table", Description = "Wooden dining table.", Price = 499.99m, Stock = 15,
            CategoryId = 9
        },
        new Product
        {
            Id = 11, Name = "Notebook", Description = "Spiral notebook.", Price = 2.99m, Stock = 300, CategoryId = 10
        },
        new Product
        {
            Id = 12, Name = "Chips", Description = "Pack of potato chips.", Price = 1.49m, Stock = 500, CategoryId = 11
        },
        new Product
        {
            Id = 13, Name = "Car Vacuum", Description = "Portable car vacuum cleaner.", Price = 49.99m, Stock = 25,
            CategoryId = 12
        },
        new Product
        {
            Id = 14, Name = "Guitar", Description = "Acoustic guitar.", Price = 199.99m, Stock = 10, CategoryId = 13
        },
        new Product
        {
            Id = 15, Name = "Garden Hose", Description = "25ft garden hose.", Price = 19.99m, Stock = 40,
            CategoryId = 14
        },
        new Product
        {
            Id = 16, Name = "Luggage", Description = "Travel suitcase.", Price = 99.99m, Stock = 35, CategoryId = 15
        },
        new Product
        {
            Id = 17, Name = "Dog Food", Description = "Premium dog food.", Price = 39.99m, Stock = 60, CategoryId = 16
        },
        new Product
        {
            Id = 18, Name = "Wristwatch", Description = "Luxury wristwatch.", Price = 299.99m, Stock = 20,
            CategoryId = 17
        },
        new Product
        {
            Id = 19, Name = "Earrings", Description = "Gold earrings.", Price = 89.99m, Stock = 25, CategoryId = 18
        },
        new Product
        {
            Id = 20, Name = "Backpack", Description = "School backpack.", Price = 39.99m, Stock = 45, CategoryId = 19
        }
    };

    public static readonly IEnumerable<User> Users = new List<User>
    {
        new User { Id = 1, Username = "user1", Email = "user1@example.com", PasswordHash = "password1" },
        new User { Id = 2, Username = "user2", Email = "user2@example.com", PasswordHash = "password2" },
        new User { Id = 3, Username = "user3", Email = "user3@example.com", PasswordHash = "password3" },
        new User { Id = 4, Username = "user4", Email = "user4@example.com", PasswordHash = "password4" },
        new User { Id = 5, Username = "user5", Email = "user5@example.com", PasswordHash = "password5" },
        new User { Id = 6, Username = "user6", Email = "user6@example.com", PasswordHash = "password6" },
        new User { Id = 7, Username = "user7", Email = "user7@example.com", PasswordHash = "password7" },
        new User { Id = 8, Username = "user8", Email = "user8@example.com", PasswordHash = "password8" },
        new User { Id = 9, Username = "user9", Email = "user9@example.com", PasswordHash = "password9" },
        new User { Id = 10, Username = "user10", Email = "user10@example.com", PasswordHash = "password10" },
        new User { Id = 11, Username = "user11", Email = "user11@example.com", PasswordHash = "password11" },
        new User { Id = 12, Username = "user12", Email = "user12@example.com", PasswordHash = "password12" },
        new User { Id = 13, Username = "user13", Email = "user13@example.com", PasswordHash = "password13" },
        new User { Id = 14, Username = "user14", Email = "user14@example.com", PasswordHash = "password14" },
        new User { Id = 15, Username = "user15", Email = "user15@example.com", PasswordHash = "password15" },
        new User { Id = 16, Username = "user16", Email = "user16@example.com", PasswordHash = "password16" },
        new User { Id = 17, Username = "user17", Email = "user17@example.com", PasswordHash = "password17" },
        new User { Id = 18, Username = "user18", Email = "user18@example.com", PasswordHash = "password18" },
        new User { Id = 19, Username = "user19", Email = "user19@example.com", PasswordHash = "password19" },
        new User { Id = 20, Username = "user20", Email = "user20@example.com", PasswordHash = "password20" }
    };

    public static readonly IEnumerable<Order> Orders = new List<Order>
    {
        new Order { Id = 1, UserId = 1, OrderDate = DateTime.UtcNow.AddDays(-5), TotalAmount = 800.00m },
        new Order { Id = 2, UserId = 2, OrderDate = DateTime.UtcNow.AddDays(-3), TotalAmount = 150.00m },
        new Order { Id = 3, UserId = 3, OrderDate = DateTime.UtcNow.AddDays(-10), TotalAmount = 500.00m },
        new Order { Id = 4, UserId = 1, OrderDate = DateTime.UtcNow.AddDays(-1), TotalAmount = 300.00m },
        new Order { Id = 5, UserId = 4, OrderDate = DateTime.UtcNow.AddDays(-7), TotalAmount = 200.00m },
        new Order { Id = 6, UserId = 5, OrderDate = DateTime.UtcNow.AddDays(-2), TotalAmount = 400.00m },
        new Order { Id = 7, UserId = 6, OrderDate = DateTime.UtcNow.AddDays(-4), TotalAmount = 600.00m },
        new Order { Id = 8, UserId = 7, OrderDate = DateTime.UtcNow.AddDays(-3), TotalAmount = 900.00m },
        new Order { Id = 9, UserId = 8, OrderDate = DateTime.UtcNow.AddDays(-6), TotalAmount = 150.00m },
        new Order { Id = 10, UserId = 9, OrderDate = DateTime.UtcNow.AddDays(-9), TotalAmount = 250.00m }
    };

    public static readonly IEnumerable<OrderItem> OrderItems = new List<OrderItem>
    {
        new OrderItem { Id = 1, OrderId = 1, ProductId = 1, Quantity = 1, Price = 699.99m },
        new OrderItem { Id = 2, OrderId = 1, ProductId = 2, Quantity = 1, Price = 1299.99m },
        new OrderItem { Id = 3, OrderId = 2, ProductId = 3, Quantity = 3, Price = 19.99m },
        new OrderItem { Id = 4, OrderId = 3, ProductId = 4, Quantity = 2, Price = 15.99m },
        new OrderItem { Id = 5, OrderId = 4, ProductId = 5, Quantity = 1, Price = 29.99m },
        new OrderItem { Id = 6, OrderId = 5, ProductId = 6, Quantity = 1, Price = 89.99m },
        new OrderItem { Id = 7, OrderId = 6, ProductId = 7, Quantity = 2, Price = 24.99m },
        new OrderItem { Id = 8, OrderId = 7, ProductId = 8, Quantity = 1, Price = 14.99m },
        new OrderItem { Id = 9, OrderId = 8, ProductId = 9, Quantity = 1, Price = 9.99m },
        new OrderItem { Id = 10, OrderId = 9, ProductId = 10, Quantity = 1, Price = 499.99m }
    };
}