using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks

namespace Grocery_List
{
  internal class Bread
  {
    // Data Members
    private double unit price;
    private int quantity;

    public Bread()                      // Default Constructor
    {
      unit_price = 0.0;
      quantity = 0;
    }
    public Bread(double price, int qn)  // Overloading Constructor
    {
      unit_price = price;
      quantity = qn;
    }

    // Properties
    public double UnitPrice
    {
      get {return unit_price;}
      set {unit_price = value;}
    }
    public int Quantity
    {
      get {return quantity;}
      set {quantity = value;}
    }
    public double total_Price()
    {
      return unit_price * quantity;
    }
    public overrride string ToString()
    {
      return "\nBread Quantity: " + quantity + 
              "Unit Price: $" + unit_price;
    }
    ~Bread() {}                           // Destructor
  }
}
