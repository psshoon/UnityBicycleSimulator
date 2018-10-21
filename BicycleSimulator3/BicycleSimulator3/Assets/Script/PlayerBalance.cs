using System.Collections;
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

    private void Update()
    {
        curRotation = rigid.rotation.eulerAngles;
    }
}
