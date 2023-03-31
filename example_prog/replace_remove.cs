using System;

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);  // 123455000  3

// ***********************

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);  // This is example data

// *************************

/* 
Here is the desired output:
Quantity: 5000
Output: <h2>Widgets &reg;</h2><span>5000</span>
*/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "Quantity: ";
string output = "Output: ";

string spanOpening = "<span>";
string spanClosing = "</span>";

int spanOpeningPosition = input.IndexOf(spanOpening);
spanOpeningPosition += 6;
int spanClosingPosition = input.IndexOf(spanClosing);

int spanMessageLength = spanClosingPosition - spanOpeningPosition;

quantity += input.Substring(spanOpeningPosition, spanMessageLength);
output += input.Replace("<div>", "").Replace("</div>", "");
Console.WriteLine(quantity);
Console.WriteLine(output);