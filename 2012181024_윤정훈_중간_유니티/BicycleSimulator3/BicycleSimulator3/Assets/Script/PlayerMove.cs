﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    PlayerBase entity;
    Rigidbody rigid;

    public AnimationCurve veloCurve;

    private void Awake()
    {
        entity = GetComponent<PlayerBase>();
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        if (entity.onBic)
        {
            entity.curAccelForce = Input.GetAxis("Vertical") * 1.4f;
            entity.curAngleAccelForce = Input.GetAxis("Horizontal") / 1.8f;
            //rigid.AddForce(-transform.forward * entity.moveEnergy * entity.curAccelForce, ForceMode.Impulse);
            //rigid.AddTorque(transform.up * entity.angleEnergy * entity.curAngleAccelForce * entity.animAngleForce, ForceMode.Impulse);

            rigid.MoveRotation(transform.rotation *
                Quaternion.Euler(transform.up * entity.angleEnergy * Time.fixedDeltaTime * entity.curAngleAccelForce * entity.animAngleForce / 8));

            if (entity.onGround)
            {
                rigid.MovePosition(transform.position -
                    (transform.forward * entity.moveVelocity * entity.curAccelForce * entity.animMoveForce * Time.fixedDeltaTime) / 100);
            }

            //if (Input.GetKey(KeyCode.W))
            //{
            //    AddMoveForwardForce();
            //}

            //if (Input.GetKey(KeyCode.S))
            //{
            //    AddMoveBackForce();
            //}

            entity.moveSpeed = (transform.forward * entity.moveVelocity * entity.curAccelForce * entity.animMoveForce).magnitude;
        }
    }

    float AcceleratorCalc(float time)
    {
        float AccelNum = 3;
        //AccelNum = time * entity.ac

        return AccelNum;
    }

    IEnumerator AccelerCalc()
    {
        while (true)
        {
            

            yield return new WaitForFixedUpdate();
        }
    }

    void AddMoveForwardForce()
    {
        //rigid.AddForce(-transform.forward  * entity.moveEnergy, ForceMode.Impulse);
        //entity.curAccelForce = Input.GetAxis("Horizontal");
        //entity.curAccelForce = Input.GetAxis("Vertical");
    }

    void AddMoveBackForce()
    {
        //if (entity.goForward)
        //{
        //    rigid.AddForce(transform.forward * entity.moveEnergy * 0.6f, ForceMode.Impulse);
        //}
        //else if (entity.isStop)
        //{
        //    print("Back");
        //    rigid.AddForce(transform.forward * entity.moveEnergy * 0.4f, ForceMode.Impulse);
        //}
    }
}
