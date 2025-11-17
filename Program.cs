using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks

namespace Grocery_List
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Item\tUnit Price\tQuantity");
      Console.WriteLine("Milk\t $4.75\t\t 1\nBread\t $2.50\t\t 2\nEggs\t $4.00\t\t 3");
      Console.Read();

      Milk my_milk = new Milk(4.75,1);
      Bread my_bread = new Bread(2.5,2);
      Eggs my_eggs = new Eggs(4.00,3);

      Grocery my_grocery = new Grocery(my_milk, my_bread, my_eggs);
      Console.WriteLine(my_grocery.ToString());
      Console.WriteLine($"Total Expense: ${my_grocery.expense()}");
      Console.Read();
    }
  }
}
