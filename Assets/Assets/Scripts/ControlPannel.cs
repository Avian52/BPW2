using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPannel : MonoBehaviour {

    public int but1;
    public int but2;
    public int but3;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    private Animator animator;

    private void Start()
    {
        if(button1 == null)
        {
            button1 = GameObject.Find("knop1");
        }

        if (button2 == null)
        {
            button2 = GameObject.Find("knop2");
        }

        if (button3 == null)
        {
            button3 = GameObject.Find("knop3");
        }

        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(button1.GetComponent<ButtonPress>() == null)
        {
            button1.AddComponent<ButtonPress>();
        }

        if (button2.GetComponent<ButtonPress>() == null)
        {
            if (but1 == 5)
            {
                button2.AddComponent<ButtonPress>();
                animator.SetBool("task1done", true);
            }
        }

        if (button3.GetComponent<ButtonPress>() == null)
        {
            if (but2 == 3)
            {
                button3.AddComponent<ButtonPress>();
                animator.SetBool("task2done", true);
            }
        }

        if (but3 == 1)
        {
            animator.SetBool("task3done", true);
        }

        print(but1);
        print(but2);
    }
}
