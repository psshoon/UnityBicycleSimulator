using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
    
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float distance = 10.0f;
    [SerializeField]
    private float height = 5.0f;

    void LateUpdate()
    {
        if (!target)
            return;
        //if (transform.position.y >= 0)
        //{
        transform.position = target.position - (target.forward * distance) + (target.up * height);
        //}
        //else
        //{
        //    transform.position = new Vector3(transform.position.x, 0, transform.position.y);
        //}

        transform.LookAt(target);
    }
}
