using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Animator animator;
    private void OnMouseDown()
    {
        animator.SetTrigger("Anim");
    }
}