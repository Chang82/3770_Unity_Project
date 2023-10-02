using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Cube : MonoBehaviour
{
     public int speed = 5;

     void Update()
     {
          //transform.Translate(0, speed, 0);
     }

     void FixedUpdate()
     {
          transform.Translate(0, speed * Time.fixedDeltaTime, 0);
     }



}
