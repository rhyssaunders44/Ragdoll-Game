using System;
using System.Collections;
using System.Collections.Generic;
using RagDollGame;
using UnityEngine;

public class Disabler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Box")) return;
        GetComponentInParent<Ragdoller>().EnableRagdoll();
        enabled = false;
    }
}
