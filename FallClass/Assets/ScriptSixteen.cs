using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSixteen : MonoBehaviour
{
 public Gameobject otherGameObject


 private ScriptSeventeen scriptSeventeen;
 private ScriptEighteen scriptEighteenprivate
 private BoxCollider boxCol;

 void Awake()
 {
  ScriptSeventeen = GetComponent<ScriptSeventeen>();
  scriptEighteen =
   otherGameObject.GetComponent<ScriptEighteen>();
  boxCol = scriptEighteen.GetComponent<BoxCollider>();
 }
 
 
 void Start ()

 {
  boxCol.size = new Vector3(3, 3, 3);
  Debug.Log("The player's score is" + anotherScript.playerScore);
  Debug.Log("The player has died" +
            ScriptEighteen.numberOfPlayerDeaths + "times");
 }
}
