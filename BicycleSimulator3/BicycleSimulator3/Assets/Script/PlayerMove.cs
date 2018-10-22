using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    PlayerBase entity;
    Rigidbody rigid;

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
            entity.curAngleAccelForce = Input.GetAxis("Horizontal") / 1.7f;

            rigid.AddForce(-transform.forward * entity.moveEnergy * entity.curAccelForce, ForceMode.Impulse);
            rigid.AddTorque(transform.up * entity.angleEnergy * entity.curAngleAccelForce, ForceMode.Impulse);

            //if (Input.GetKey(KeyCode.W))
            //{
            //    AddMoveForwardForce();
            //}

            //if (Input.GetKey(KeyCode.S))
            //{
            //    AddMoveBackForce();
            //}
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
