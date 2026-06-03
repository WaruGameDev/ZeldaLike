using System;
using UnityEngine;

public class AnimationCharacter : MonoBehaviour
{
   public Animator animator;
   private Rigidbody rb;

    private void Awake()
    {
         rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 rbVel = rb.linearVelocity;
        float speed = MathF.Abs(rbVel.x) + MathF.Abs(rbVel.z);
        animator.SetFloat("Speed", speed);
    }
}
