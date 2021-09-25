using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTen2 : MonoBehaviour
{
    public GameObject myObject;


    void Start()
    {
        Debug.Log("Active Self: " + myObject.avtiveSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
}
