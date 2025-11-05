Console.WriteLine();

string [] orderIDs = {"B123" ,"C234" ,"A345" ,"C15" ,"B177" ,"G3003" ,"C235" ,"B179"};

Console.WriteLine("List of all orders that need further investigation");
foreach (string id in orderIDs) {
    if (id.StartsWith("B")) {
        Console.WriteLine($"\tOrder Id: {id}");
    }
}

Console.WriteLine();
