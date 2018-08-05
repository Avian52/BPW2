using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeurAnimatieScript : MonoBehaviour {

    [SerializeField]
    private Animator animator;

    void OnMouseUp()
    {
        animator.SetTrigger("playAnimation");
    }
}
