using System;
using System.Collections;

// A Queue is first in first out
var myQueue = new Queue();
myQueue.Enqueue("first");
myQueue.Enqueue("secode");
myQueue.Enqueue("third");

int items = myQueue.Count;  // items = 3
var firstItem = myQueue.Peek();

Console.WriteLine(firstItem);   // "first"

var itemRemoved = myQueue.Dequeue();

Console.WriteLine((itemRemoved));   // "first"