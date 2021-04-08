using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transitions : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            animator.SetBool("isRuning", true);
        }
        if (!Input.GetKey("w"))
        {
            animator.SetBool("isRuning", false);
        }
    }
}
