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
        y += Input.GetAxis("Mouse X") * Time.deltaTime * 100;
        if (x <= 30 && x >= -30)
        {
            x += Input.GetAxis("Mouse Y") * Time.deltaTime * 80;
        }

        else
        {
            if (x > 30)
            {
                x = 30;
            }

            if (x < -30)
            {
                x = -30;
            }
        }

        transform.rotation = Quaternion.Euler(new Vector3(-x, y, transform.eulerAngles.z));
    }
}