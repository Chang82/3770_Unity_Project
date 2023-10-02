using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class MyCamera : MonoBehaviour
{

     float speed = 0.5f;
     Camera cam;
     Vector3 f { get => cam.transform.forward; }


     void Start()
     {
          cam = Camera.main;

          cam.transform.position = new Vector3(5.5f, 8.5f, -12);
          cam.transform.rotation = Quaternion.Euler(30, -25, 0);
     }


     void Update()
     {
          if (Input.GetKey(KeyCode.W))
          {
               transform.position += f * speed * Time.deltaTime;
          }
          else if (Input.GetKey(KeyCode.S))
          {
               transform.position += f * speed * Time.deltaTime * -1;
          }
     }

     void OnGUI()
     {
          if (GUILayout.Button("+"))
               speed += 1f;
          if (GUILayout.Button("-"))
               speed = speed <= 0 ? 0 : speed - 1;
     }



}
