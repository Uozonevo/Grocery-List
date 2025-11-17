using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks

namespace Grocery_List
{
  internal class Grocery
  {
    // Data Members
    private Milk my_milk;
    private Bread my_bread;
    private Eggs my_eggs;

    public Grocery(Milk my_milk, Bread my_bread, Eggs my_eggs) // Overloading Constructor
    {
      // Assignment
      this.my_milk = my_milk;
      this.my_bread = my_bread;
      this.my_eggs = my_eggs;
    }
    
    public double expense()
    {
      return my_milk.total_price() +
              my_eggs.total_price() +
              my_bread.total_price();
    }
    public overrride string ToString()
    {
      return my_milk.ToString() +
              my_eggs.ToString() +
              my_bread.ToString()
    }
    ~Grocery() {}                              // Destructor
  }
}
