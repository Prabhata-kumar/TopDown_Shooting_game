using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Camera mainCamera;
    private Vector3 mousePose;                                                                                                                                                                                                                    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePose = mainCamera.ScreenToWorldPoint(mousePose);   
        Vector3 rotation =mousePose - transform.position;
        float rotz = Mathf.Atan2(rotation.y, rotation.x) ;
        transform.rotation = Quaternion.Euler(0,0,rotz);
    }
}
