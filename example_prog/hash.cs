using System;
using System.Collections;

Hashtable hashtable = new Hashtable();
hashtable.Add("key1", "value1");
hashtable.Add("key2", "value2");

string value = (string)hashtable["key1"];
Console.WriteLine(value); // Output: "value1"
