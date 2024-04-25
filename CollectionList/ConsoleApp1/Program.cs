using System.ComponentModel;
using connect;

namespace connect
{
  class Program {

    public static void Main(string[] args) {
      string filePath = "data.csv";

<<<<<<< HEAD
      // Registry.Register();
      Log_in.Login();
      Add.CreateAndDisplayArray();
      Reader.Read();
      Editor.Edit();
       Registry.Register();
       Log_in.Login();
=======
      //  Registry.Register();
      //  Log_in.Login();
>>>>>>> 6f842fe9fac1459f1c467481853f873d539d26dc
      // Editor.Edit();

      // bool ascendingOrder = false; // Change this to true or false as needed
            
      // Sort.SortCsv(filePath, 1, ascendingOrder);
      // Console.WriteLine($"CSV file sorted in {(ascendingOrder ? "ascending" : "descending")} order by the second column.");


      Add.AddRecord(filePath);
      Reader.Read();
      Remove.RemoveRecord(filePath);
      Reader.Read();


>>>>>>> d79d803aaddb5b6f783936b290c73ba29d111519
    } 
  }
}