using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysPractice2 : MonoBehaviour
{
 private string[] cars = {"Volvo", "BMW", "Ford", "Mazda", "Clown Car"};
  Array.Sort(cars);
 foreach (string i in cars)
 {
  Console.WriteLine(i)
 }
}
