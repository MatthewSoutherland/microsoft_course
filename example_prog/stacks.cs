using System;
using System.Collections;

// last in last out
// good example of when to use a stack is undo
var myStack = new Stack();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);

myStack.Pop();

foreach (var item in myStack)
{
    Console.WriteLine(item);
}