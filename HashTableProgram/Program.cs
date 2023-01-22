using HashTableProgram;

Console.WriteLine("Hash table demo"); //() []

//ToFindIndexOfTheWords<string, string> hash = new ToFindIndexOfTheWords<string, string>(5);
//hash.Add("0", "To");
//hash.Add("1", "be");
//hash.Add("2", "or");
//hash.Add("3", "not");
//hash.Add("4", "to");
//hash.Add("5", "be");
//string hash5 = hash.Get("5");
//Console.WriteLine("5th index value: " + hash5);
//string hash2 = hash.Get("2");
//Console.WriteLine("2th index value: " + hash2);
//Console.ReadKey();

//HashTable Removal Of Word 
HashTableRemovalWord<string, string> hash = new HashTableRemovalWord<string, string>(5);
hash.Add("0", "To");
hash.Add("1", "be");
hash.Add("2", "or");
hash.Add("3", "not");
hash.Add("4", "to");
hash.Add("5", "be");
string hash5 = hash.Get("5");
Console.WriteLine("5th index value: " + hash5);
string hash2 = hash.Get("2");
Console.WriteLine("2th index value: " + hash2);
Console.ReadKey();