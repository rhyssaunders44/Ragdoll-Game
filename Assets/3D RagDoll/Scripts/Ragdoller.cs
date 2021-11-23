using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace RagDollGame
{
    public class Ragdoller : MonoBehaviour
    {
        private Joint[] joints;
        private Rigidbody[] bodies;
        [SerializeField] private float minForceToAddScore = 1f;
        [SerializeField] private GameObject UIManager;
        private UIManager _manager;
        private bool active;
        private void Start()
        {
            DisableRagdoll();
            joints = GetComponentsInChildren<Joint>();
            _manager = UIManager.GetComponent<UIManager>();
        }

        public void DisableRagdoll()
        {
            Animator anim = GetComponent<Animator>();
            anim.enabled = true;
            
            bodies = GetComponentsInChildren<Rigidbody>();
            foreach (Rigidbody body in bodies)
            {
                body.isKinematic = true;
            }
        }

        public void EnableRagdoll()
        {
            var anim = GetComponent<Animator>();
            anim.enabled = false;
                
            bodies = GetComponentsInChildren<Rigidbody>();
            foreach (var body in bodies)
            {
                body.isKinematic = false;
            }

            active = true;
        }
        


        public void ScoreRagdoll()
        {
            float totalForce = 0;
            foreach (Joint joint in joints)
            {
                if (joint.currentForce.magnitude > minForceToAddScore)
                {
                    totalForce += joint.currentForce.magnitude * 0.1f;
                }
            }
            _manager.score += totalForce;
            _manager.UpdateScores();
        }
    }
}