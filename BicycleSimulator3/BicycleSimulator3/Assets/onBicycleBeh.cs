using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onBicycleBeh : StateMachineBehaviour {
    PlayerBase entity;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        entity = animator.GetComponent<PlayerBase>();
        if (stateInfo.IsName("OnBicycle_01_Idle"))
        {
            entity.onBic = true;
            entity.isStop = true;
        }

        else if (stateInfo.IsName("Offbicycle_01 0"))
        {
            entity.onBic = false;
        }

        else if (stateInfo.IsName("StartPush_01"))
        {
            entity.isStop = false;
        }

        else if (stateInfo.IsName("RideLoop_01"))
        {
            entity.isMove = true;
        }

        else if (stateInfo.IsName("Break_01"))
        {
            entity.isMove = false;
        }

        else if (stateInfo.IsName("RightTilt") || stateInfo.IsName("LeftTilt"))
        {
            entity.isMove = false;
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}
}
