
List<string> coffees = new List<string>(); // Creating an empty list

Console.WriteLine("Lütfen listenizde olmasını istediğiniz 5 kahveyi yazınız: "); // Asking user to fill the list

for (int i = 0; i < 5; i++)
{
    coffees.Add(Console.ReadLine()); // Using Add method to add elements to the list
}

Console.WriteLine("--------------------------------------");
Console.WriteLine("Girilen kahve isimleri: "); 

foreach (string coffee in coffees) // Printing the elements of the list
{
    Console.WriteLine(coffee);
}
