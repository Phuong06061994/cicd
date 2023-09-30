

using ComplexType;
using ComplexType.Entities;
using var dbContext = new ApplicationDbContext();

var book = new Book()
{
    Name = "Test",
    Author = new Author()
    {
        Country = "VN",
        FirstName = "Test",
        LastName = "Test",
    },
    Description = "Test",
    Title = "Test",
};

dbContext.Books.Add(book);
dbContext.SaveChanges();

Console.WriteLine("Hello, World!");
