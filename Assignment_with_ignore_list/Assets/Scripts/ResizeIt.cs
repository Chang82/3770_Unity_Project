using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeIt : MonoBehaviour
{

     int speed = 1;
     float big = 4;
     float small = 1;
     bool goBig = true;


     void FixedUpdate()
     {
          //back and forth
          if (transform.localScale.x == big)
               goBig = false;
          else if (transform.localScale.x == small)
               goBig = true;


          //move
          var scale = goBig ? big : small;
          transform.localScale = Vector3.MoveTowards(
               transform.localScale,
               new Vector3(scale, scale, scale),
               speed * Time.fixedDeltaTime);

     }








}
