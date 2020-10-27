using System;

class BookException : Exception
{
    public BookException()
    {

    }
    //constructor that takes title, price and number of pages as parameters and create an error message that is passed to the Exception class
    public BookException(string title, double price, int numOfPages) : base(String.Format("*************** For {0}, ratio is invalid.\n...Price is ${1} for {2} pages.\n", title, price, numOfPages))
    {

    }
}