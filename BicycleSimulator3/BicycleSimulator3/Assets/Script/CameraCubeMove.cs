using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCubeMove : MonoBehaviour {
    float x, y;
    
	void Start () {
        x = transform.eulerAngles.x;
        y = transform.eulerAngles.y;
	}
	
	void Update () {
        //if (transform.eulerAngles.x < 0)
        //{            
        //    x = 0;
        //}
        //else
        //{
        //    x += Input.GetAxis("Mouse Y") * Time.deltaTime * 80;            
        //}
        x += Input.GetAxis("Mouse Y") * Time.deltaTime * 80;
        y += Input.GetAxis("Mouse X") * Time.deltaTime * 100;
        transform.rotation = Quaternion.Euler(new Vector3(-x, y, transform.eulerAngles.z));

        //print(Vector3.Cross(transform.forward, Vector3.up));
        //print(Vector3.Angle(transform.forward, Vector3.up));
	}
}