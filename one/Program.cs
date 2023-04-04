using System;
var s = new Student();
var cal = new Student.calculateHandler(s.Add);
s.calculate(10, 5, cal);

var t = new StudentMath();
t.Add(10, 5);