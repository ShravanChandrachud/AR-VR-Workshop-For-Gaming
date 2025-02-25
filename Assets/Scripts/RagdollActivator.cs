using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollActivator : MonoBehaviour
{
    private Rigidbody[] ragdollBodies;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        ragdollBodies = GetComponentsInChildren<Rigidbody>();

        // Enable ragdoll immediately on start
        EnableRagdoll();
    }

    public void EnableRagdoll()
    {
        foreach (Rigidbody rb in ragdollBodies)
        {
            rb.isKinematic = false; // Enable physics
        }

        if (animator != null)
        {
            animator.enabled = false; // Disable animations
        }
    }

    void Update()
    {

    }
}
