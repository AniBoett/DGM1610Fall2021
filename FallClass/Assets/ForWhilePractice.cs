using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForWhilePractice : MonoBehaviour
{

for (int i = 0; i < 10; i++)
{
    {
        if (i == 5)
        {
            break;
        }

        if (i == 4)
        {
            continue;
        }
    }
    Console.WriteLine("Yes"); //Codeblock executed under above conditions
}
}
