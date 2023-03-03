using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class anim : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetTrigger("close");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
