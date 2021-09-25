using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFourteen : MonoBehaviour
{
 public float range;
 public Text textOutput;


 void Update()
 {
  float h = Input.GetAxis("Horizzontal");
  float xPos = h * range;

  transform.position = new Vector3(xPos, 2f, 0);
  textOutput.text = "value Returned: " + h.ToString("F2");
 }
}
