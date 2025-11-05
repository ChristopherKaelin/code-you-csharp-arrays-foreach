Console.WriteLine();

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

// Console.WriteLine($"First fraudulent order ID: {fraudulentOrderIDs[0]}");
Console.WriteLine($"all fraudulent order IDs: {string.Join(", ", fraudulentOrderIDs)}");
Console.WriteLine();
