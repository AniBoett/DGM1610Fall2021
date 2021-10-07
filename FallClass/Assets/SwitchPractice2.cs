using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPractice2 : MonoBehaviour
{
   private int day = 2;
   switch (day)
   {
      case 1:
      Console.WriteLine("Monday");
      yield break;
      case 2:
      Console.WriteLine("Tuesday");
      yield break;
   }
}
