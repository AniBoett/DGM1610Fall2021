using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringsTest1 : MonoBehaviour
{
  string greeting = "Hello"
  private string firstName = "John";
  private string lastName = "Doe";
  private string name = firstName + lastName;
  Console.writeLine(name);
  private string name = $"My full name is: {firstName} {lastName}";
    Console.WriteLine(name);
    private string myString = "Hello";
    Console.Writeline(myString[0]);
    private string txt = "hello";
    Console.WriteLine(txt.Length);
    private string txt = "Hello World";
    Console.WriteLine(txt.ToUpper);
}
