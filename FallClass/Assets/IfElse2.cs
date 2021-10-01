using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse2 : MonoBehaviour
{
   private int time = 10;
   private string result = (time < 18) ? "Good day." : "Good evening.";
   Console.WriteLine(result);
}
