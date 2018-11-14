using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour {
    PlayerBase entity;
    Animator anim;

    private void Awake()
    {
        entity = GetComponent<PlayerBase>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        anim.SetFloat("MoveSpeed", entity.moveSpeed);
        entity.animMoveForce = anim.GetFloat("AnimMoveForce");
        entity.animAngleForce = anim.GetFloat("AnimAngleForce");

        if (Input.GetKeyDown(KeyCode.R))
        {
            OnBicycle();
        }

        if (entity.onBic)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                MoveBackForward();
            }
            else
            {
                StopBackForward();
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                Turn();
            }
            else
            {
                stopTurn();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetTrigger("Break");
            }
        }
    }

    void OnBicycle()
    {
        if(entity.isStop)
            anim.SetBool("onBicycle", !anim.GetBool("onBicycle"));
    }

    void MoveBackForward()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            entity.forwardButtonPress = true;
            entity.backButtonPress = false;
            anim.SetBool("ForwardButtonPress", true);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            entity.backButtonPress = true;
            entity.forwardButtonPress = false;
            anim.SetBool("BackButtonPress", true);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.SetBool("PowerUp", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anim.SetBool("PowerUp", false);
        }
    }

    void StopBackForward()
    {
        entity.backButtonPress = false;
        entity.forwardButtonPress = false;
        anim.SetBool("ForwardButtonPress", false);
        anim.SetBool("BackButtonPress", false);
    }

    void Turn()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("LeftButtonPress", true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {

            anim.SetBool("RightButtonPress", true);
        }
    }

    void stopTurn()
    {
        anim.SetBool("LeftButtonPress", false);
        anim.SetBool("RightButtonPress", false);
    }
}
