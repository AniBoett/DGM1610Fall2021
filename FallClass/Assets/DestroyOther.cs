using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOther : MonoBehaviour
{
 public GameObject other;


 void UPdate()
 {
  if (Input.GetKey(KeyCode.Space))
  {
   Destroy(other);
  }
 }
}
