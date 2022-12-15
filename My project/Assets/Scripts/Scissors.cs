using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scissors : MonoBehaviour
{
    public Animator ScissorsAnimator;
    public float Scissors_Anim_Speed = 1f;

    private void Start()
    {
        ScissorsAnimator = GetComponent<Animator>();

        if (ScissorsAnimator == null)
        {
            Debug.LogWarning("ScissorsAnimator is NULL");
        }
    }

    private void FixedUpdate()
    {
        ScissorsAnimator.speed = Scissors_Anim_Speed;
        Scissors_Anim_Speed = ScissorsAnimator.speed;
    }

    public void Scissors_Animation()
    {
        ScissorsAnimator.Play("Scissors_Anim", 0, 0.25f);
    }

}
