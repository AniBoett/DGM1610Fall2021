using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysPractice : MonoBehaviour
{
    private string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        cars[0] = "Opel";
    for (int i = 0; i<cars.Length; i++)
    {
        Console.WriteLine(cars[1]);
    }
}
