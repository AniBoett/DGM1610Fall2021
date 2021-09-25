using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetButton : MonoBehaviour
{
  public Image graphic;
  public Sprite standard;
  public Sprite downgfx;
  public Sprite upgfx;
  public Sprite heldgfx;
  public Text boolDisplay1;
  public Text boolDisplay2;
  public text boolDisplay3;

  voidStart()
  {
    graphic.sprite = standard;
  }

  void Update()
  {
    bool down = Input.GetKeyDown(KeyCode.Space);
    bool held = Input.GetKeyDown(KeyCode.Space);
    bool up = Input.GetKeyUp(KeyCode.Space);

    if (down)
    {
      graphic.sprite = downgfx;
    }
    else if (up)
    {
      graphic.sprite = upgfx;}
  }
  else

  {
    graphic.sprite = standard;
  }
  
  boolDisplay1.text = " " + down;
  boolDisplay2.text = " " + held;
  boolDisplay3.text = ' ' + held;
}
