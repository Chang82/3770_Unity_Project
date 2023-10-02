using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveIt : MonoBehaviour
{

     int speed = 1;
     Vector3 p0 = new Vector3(3, 1, 0);
     Vector3 p1 = new Vector3(-3, 1, 0);
     bool gotoP0 = true;

     void Awake()
     {
          var rb = GetComponent<Rigidbody>();
          if (rb != null)
               rb.useGravity = false;
     }

     void FixedUpdate()
     {
          //back and forth
          if (transform.position == p0)
               gotoP0 = false;
          else if (transform.position == p1)
               gotoP0 = true;


          //move
          var target = gotoP0 ? p0 : p1;
          transform.position = Vector3.MoveTowards(
               transform.position,
               target,
               speed * Time.fixedDeltaTime);

     }


}
