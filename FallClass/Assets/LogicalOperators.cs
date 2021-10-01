using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour
{
    private int x = 5;
    Console.WriteLine(x > 3 && x < 10); // returns true since both equations are true
    Console.WriteLine(x < 5 || x < 4); // returns true since one statement is true
    Console.Writeline!(x < 5 && x < 10) // returns false since both statements are true
}
