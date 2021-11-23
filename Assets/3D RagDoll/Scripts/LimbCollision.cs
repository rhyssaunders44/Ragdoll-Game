using System;
using System.Collections;
using System.Collections.Generic;
using RagDollGame;
using UnityEngine;

public class LimbCollision : MonoBehaviour
{
    private Ragdoller parentRagdoller;
    private Rigidbody thisRB;
    private void Start()
    {
        parentRagdoller = GetComponentInParent<Ragdoller>();
        thisRB = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (!other.collider.CompareTag("Floor"))
        {
            parentRagdoller.EnableRagdoll();
            parentRagdoller.ScoreRagdoll();
        }
    }
}
