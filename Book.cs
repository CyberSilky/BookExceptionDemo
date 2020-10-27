using System;
class Book
{
    //member variables
    private string title;
    private string author;
    private double price;
    private int numberOfPages;

    //property to get and set Title
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    //property to get and set Author
    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    //property to get and set Price
    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    //property to get and set Number Of Pages
    public int NumberOfPages
    {
        get { return numberOfPages; }
        set { numberOfPages = value; }
    }
}