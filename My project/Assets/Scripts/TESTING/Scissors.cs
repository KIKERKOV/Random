using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissors : MonoBehaviour
{
    public Animator ScissorsAnimator;
    public AnimationClip ScissorsAnimationClip;
    public float Scissors_Anim_Speed;

    private void Start()
    {
        ScissorsAnimator = GetComponent<Animator>();
        ScissorsAnimationClip = GetComponent<AnimationClip>();

        if (ScissorsAnimationClip == null)
        {
            Debug.LogWarning("ScissorsAnimationClip is NULL");
        }
        if (ScissorsAnimator == null)
        {
            Debug.LogWarning("ScissorsAnimator is NULL");
        }


    }

    private void FixedUpdate()
    {
        ScissorsAnimator.speed = Scissors_Anim_Speed;
    }


    public void Scissors_Animation()
    {
        
    }

    public void OnGUI()
    {
        GUI.Label(new Rect(new Vector2(0.0f,0.0f), new Vector2(10.0f, 10.0f)), "Speed");

    }

}
