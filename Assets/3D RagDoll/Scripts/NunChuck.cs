using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NunChuck : MonoBehaviour
{
    private Canvas _canvas;
    [SerializeField] private Camera mainCam;
    private Ray worldPos;
    public LayerMask _layerMask;
    [SerializeField] private GameObject empty;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void FixedUpdate()
    {
        worldPos = mainCam.ScreenPointToRay(Input.mousePosition);
        Debug.Log(worldPos);
        if(Physics.Raycast(worldPos , out RaycastHit hit, Mathf.Infinity, _layerMask))
        {
            empty.transform.position = hit.point;
        }  
        
    }
}
