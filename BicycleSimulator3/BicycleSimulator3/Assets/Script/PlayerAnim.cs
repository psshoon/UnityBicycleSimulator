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
        if (Input.GetKeyDown(KeyCode.R))
        {
            OnBicycle();
        }

        if (entity.onBic)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                
            }
        }
    }

    void OnBicycle()
    {
        anim.SetBool("onBicycle", !anim.GetBool("onBicycle"));
    }
}
