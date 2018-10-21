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
            if (Input.GetKey(KeyCode.W))
            {
                AddMoveForwardForce();
            }

            if (Input.GetKey(KeyCode.S))
            {
                AddMoveBackForce();
            }

        }
	}

    void AddMoveForwardForce()
    {
        rigid.AddForce(-transform.forward  * entity.moveEnergy, ForceMode.Impulse);
    }

    void AddMoveBackForce()
    {
        if (entity.isMove)
        {
            rigid.AddForce(transform.forward * entity.moveEnergy * 0.6f, ForceMode.Impulse);
        }
        else if (entity.isStop)
        {
            print("Back");
            rigid.AddForce(transform.forward * entity.moveEnergy * 0.4f, ForceMode.Impulse);
        }
    }
}
