using System;

namespace ClassWork2
{
    public interface Person
    {
        String name { get; set; }
        int age { get; set; }
        int cardNumber { get; set; }
        public void LogIn();
        public void ViewItem(Item item);
    }
    public class Librarian : Person
    {
        public String name { get; set; }
        public int age { get; set; }
        public int cardNumber { get; set; }
        public Librarian(String name, int age, int cardNumber)
        {
            this.name = name;
            this.age = age;
            this.cardNumber = cardNumber;
        }
        public void LogIn()
        {
            Console.WriteLine("Librarian logged in. Welcome, {0}!", name);
        }
        public void ViewItem(Item item)
        {
            item.View();
        }
    }
    public class User : Person
    {
        public String name { get; set; }
        public int age { get; set; }
        public int cardNumber { get; set; }
        public User(String name, int age, int cardNumber)
        {
            this.name = name;
            this.age = age;
            this.cardNumber = cardNumber;
        }
        public void LogIn()
        {
            Console.WriteLine("User logged in. How can we help you, {0}?", name);
        }
        public void ViewItem(Item item)
        {
            item.View();
        }
    }
    public abstract class Item
    {
        protected String title;
        public abstract void View();
        public void CheckOut()
        {
            Console.WriteLine("{0} checked out.", title);
        }
        public void Return()
        {
            Console.WriteLine("{0} returned.", title);
        }
    }
    public class Book : Item
    {
        String author;
        public Book(String title, String author)
        {
            this.title = title;
            this.author = author;            
        }
        public override void View()
        {
            Console.WriteLine("Reading book: {0}", title);
        }
    }
    sealed public class Audiobook : Book
    {
        public Audiobook(String title, String author) : base(title, author)
        {
        }
        public override void View()
        {
            Console.WriteLine("Listening to audiobook: {0}", title);
        }
    }
    sealed public class Movie : Item
    {
        String director;
        public Movie(String title, String director)
        {
            this.title = title;
            this.director = director;
        }
        public override void View()
        {
            Console.WriteLine("Watching movie: {0}", title);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Book tom = new Book("Tom Sawyer", "Mark Twain");
            Movie jp = new Movie("Jurassic Park", "Steven Spielberg");
            Audiobook lotr = new Audiobook("The Lord of the Rings", "J.R.R. Tolkien");

            Librarian librarian = new Librarian("Alice", 35, 12345);
            User user = new User("Bob", 25, 67890);
            
            Console.WriteLine(" ");
            user.LogIn();
            jp.CheckOut();
            user.ViewItem(jp);
            jp.Return();
            Console.WriteLine(" ");
            librarian.LogIn();
            librarian.ViewItem(tom);
            Console.WriteLine(" ");
        }
    }
}