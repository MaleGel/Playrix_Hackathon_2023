using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleObjects : MonoBehaviour
{
    public string objID;
    public Animator animator;
    public bool onAnimation;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void InteractObj()
    {
        switch (objID)
        {
            case "Refrigirator":
                if (!animator.GetBool("RefrigiratorOpen") && !onAnimation)
                {
                    animator.Play("RefrigiratorOpen", 0);
                    animator.SetBool("RefrigiratorOpen", true);
                    onAnimation= true;
                }
                else if (animator.GetBool("RefrigiratorOpen") && !onAnimation)
                {
                    animator.Play("RefrigiratorClose", 0);
                    animator.SetBool("RefrigiratorOpen", false);
                    onAnimation = true;
                }
                break;
        }
    }

    private void StopAnim()
    {
        onAnimation= false;
    }
}
