using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkerController : MonoBehaviour
{
    private Animator animator;
    private bool isStopped;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerClick()
    {
        if (isStopped)
        {
            animator.SetTrigger("Resume");
            animator.SetFloat("Speed", 1);
        }
        else
        {
            animator.SetTrigger("Stop");
            animator.SetFloat("Speed", 0);
        }
        isStopped = !isStopped;
    }


}
