using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNextAnimationClip : MonoBehaviour
{
    public GameObject animatorGameobject;
    private Animator anim;

    void Start() {
        anim = animatorGameobject.GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            PlayClip();
        }
    }

    public void PlayClip() {
        anim.Play("Arm_Dog_Attack_F");
    }
}
