using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAllAnimClips : MonoBehaviour
{
    private Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(PlayAll());
    }

    public IEnumerator PlayAll()
    {
        foreach (AnimationClip clip in animator.runtimeAnimatorController.animationClips)
        {
            animator.Play(clip.name);
            yield return new WaitForSeconds(clip.length);
        }
    }
}
