using System;

var names = new List<string> { "Joe", "Jerry", "Jimmy", "Jesse" };
names.Add("Jacob");
names.Remove("Jesse");
foreach (string name in names)
{
    Console.WriteLine(name);    // "Joe", "Jerry", "Jimmy", "Jacob"
}

int guyIndex = names.IndexOf("Jerry");  // 1

names.Sort();   // doesnt create a duplicate. sorts on the spot

foreach (string name in names)
{
    // Console.WriteLine(name);    // "Jacob", "Jerry", "Jimmy", "Joe"
}

int len = names.Count();    // 4