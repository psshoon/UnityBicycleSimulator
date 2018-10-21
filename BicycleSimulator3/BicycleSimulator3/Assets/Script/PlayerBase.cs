using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour {
    public float moveSpeed, moveEnergy, angleEnergy = 0;
    public bool isMove, isStop, onBic, isTurn, isTilt = false;

    // 본인 상태는 StateMachineBehaviour기반으로 상태를 바꿔줌
    // PlayerAnim 에서는 키입력을 통해 그 Animation State를 바꿔주기만함
    // PlayerMove 에서는 키입력을 통해 속도값과 에너지 위주로만 바꿔줌.
}