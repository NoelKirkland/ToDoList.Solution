using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{

  public class Program
  {
      public static void ToDoList(string userAnswer)
      {
        if (userAnswer == "Add" || userAnswer == "add")
        {
          Console.WriteLine("Type a description of your task.");
          string userTask = Console.ReadLine();
          Item newTask = new Item(userTask);
          Main();
        } 
        else if (userAnswer == "View" || userAnswer == "view")
        {
          List<Item> displayList = Item.GetAll();

          foreach (Item thisItem in displayList)
          {
            Console.WriteLine(thisItem.Description);
          }
          Main();
        }
        else
        {
          Main();
        }
      }

      public static void Main()
      {
        Console.WriteLine("Welcome to the To Do List.");
        Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
        string response = Console.ReadLine();
      
        ToDoList(response);
      }
  }
}

