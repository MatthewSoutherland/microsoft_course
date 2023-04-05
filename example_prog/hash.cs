using System;
using System.Collections;

// SortedList and Hashtable both work the same
// var hashtable = new SortedList();
Hashtable hashtable = new Hashtable();
hashtable.Add("key1", "value1");
hashtable.Add("key2", "value2");

string value = (string)hashtable["key1"];
Console.WriteLine(value); // Output: "value1"

foreach (DictionaryEntry entry in hashtable)
{
    Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
}