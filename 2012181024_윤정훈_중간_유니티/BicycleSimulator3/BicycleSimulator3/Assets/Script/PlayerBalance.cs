﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBalance : MonoBehaviour {
    PlayerBase entity;
    Rigidbody rigid;

    public Vector3 curRotation;
    public Vector3 WantedRotation;

    private void Awake()
    {
        entity = GetComponent<PlayerBase>();
        rigid = GetComponent<Rigidbody>();
    }

    //private void Update()
    //{
    //    // zy축에 프로젝션된 좌표를 구해서
    //    Vector3 zyProjectionPoint = new Vector3(0,
    //        Mathf.Abs(Vector3.Dot(transform.up, Vector3.up)), Vector3.Dot(transform.up, -transform.forward));

    //    // tranform.up 과 외적한 값을 쿼터니언으로 변환해준다.
    //    Quaternion rotationAngle = Quaternion.Euler(
    //        Vector3.Cross(transform.up, zyProjectionPoint) * Time.fixedDeltaTime * 500);

    //    Quaternion rotationAngle2 = Quaternion.Euler(Vector3.Lerp(
    //        zyProjectionPoint,transform.up,0.5f));

    //    Quaternion rotationAngle3 = Quaternion.Euler(
    //        Vector3.Cross(transform.up, Vector3.up) * Time.fixedDeltaTime * 500);

    //    if (transform.eulerAngles.z < 20 || transform.eulerAngles.z > 340)
    //    {
            
    //    }
    //    else
    //    {
    //        if (transform.eulerAngles.z > 20 && transform.eulerAngles.z < 180)
    //        {
    //            print("123");
    //            //rigid.MoveRotation(transform.rotation * Quaternion.Euler(transform.forward * Time.fixedDeltaTime * 150));
    //        }
    //        else if (transform.eulerAngles.z < 340 && transform.eulerAngles.z > 180)
    //        {
    //            print("12332123");
    //            //rigid.MoveRotation(transform.rotation * Quaternion.Euler(-transform.forward * Time.fixedDeltaTime * 150));
    //        }
    //        //print(transform.eulerAngles.z);
    //        //rigid.MoveRotation(transform.rotation * Quaternion.Euler(-transform.forward * Vector3.Cross(transform.up, zyProjectionPoint).magnitude * 10));
    //        //rigid.MoveRotation(transform.rotation * Quaternion.Euler(transform.forward * Time.fixedDeltaTime * 10 * 50));

    //    }
    //    curRotation = rigid.rotation.eulerAngles;
    //}
}
