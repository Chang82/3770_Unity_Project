using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class RotateIt : MonoBehaviour
{
     void FixedUpdate()
     {
          var rot = new Vector3(30, 60, 90) * Time.fixedDeltaTime;

          transform.Rotate(rot);
     }
}
