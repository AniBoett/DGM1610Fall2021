using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumScript : MonoBehaviour
{
   enum Direction
   {
      North,
      East,
      South,
      West
   };

   void Start()
   {
      Direction myDirection;

      myDirection = Direction.North;
   }

   Direction ReverseDirection(Direction dir)
   {
      if (dir == Direction.North)
         dir = Direction.South;
      elseif(dir == Direction.South)
      dir = Direction.North;
      elseif(dir == Direction.East)
      dir = Direction.West;
      elseif(dir == Direction.West)
      dir = Direction.East;

      return dir;
   }
}
