using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFour : MonoBehaviour
{
  float coffeeTemperature = 850f;
  float hotLimitTemperature = 70.0f;
  float coldLimitTemperature = 40.0f;


  void Update()
  {
      if (Input.GetKeyDown(KeyCode.Space))
          TempteratureTest();

      coffeeTemperature -= Time.deltaTime * 5f;
  }
  
  
  void TemperatureTest ()
  {
      // If the coffee's temperature is greater than the hottest drinking temperature...
      if(coffeeTemperature > hotLimit Temperature)
      {
          // . . . do this.
          print("Coffee is too hot");
      }
      // If it isn't, but the coffee temperature is less than the coldest drinking temperature
      else if (coffeeTemperature < coldLimitTemperature)
      {
          // . . . do this.
          print("Coffee is just right.");
      }
  }
}
