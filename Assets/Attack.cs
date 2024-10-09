using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    GameObject Cactus1;
    GameObject Cactus2;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Cactus1 = GameObject.Find("Cactus1");
        Cactus2 = GameObject.Find("Cactus2");
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Attack2");
        }

        AnimateAttack(animator);
    }

    void AnimateAttack(Animator animator)
    {
        if (Cactus1 != null && Cactus2 != null)
        {
            float distance = Vector3.Distance(Cactus1.transform.position, Cactus2.transform.position);

            if (distance <= 5)
            {
                animator.SetTrigger("Attack2");
            }
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //AnimateAttack(animator);
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateIK is called right after Animator.OnAnimatorIK()
    override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
