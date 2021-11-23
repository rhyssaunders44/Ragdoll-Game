using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
public class Fire : MonoBehaviour
{
    public GameObject Centre;
    public Slider aimSlider;
    [SerializeField] private Vector3 aimAngle;
    private Rigidbody cubeRB;
    private Range x;
    

    private void Start()
    {
        x = new Range(-1,1 );
        var middlePoint = 0f;
        cubeRB = GetComponent<Rigidbody>();

        aimSlider.minValue = -1; 
        aimSlider.maxValue = 1;
        aimSlider.value = middlePoint;
        aimAngle = new Vector3(middlePoint, 0, 30000);
        
    }

    public void Shoot()
    {
        cubeRB.AddForce(aimAngle, ForceMode.Impulse);
    }
    
    public void Aim()
    {
        aimAngle = new Vector3(aimSlider.value * 40000, 0, 40000);
    }

    public void recentre()
    {
        gameObject.transform.position = Centre.transform.position;
    }
}
