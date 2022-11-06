using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Camera MainCamera;
    public Projactile ProjectilePrefab;
    public Transform SpawnPoint;

    // Update is called once per frame
    void Update()
    {
       var mousePose = MainCamera.ScreenToWorldPoint(Input.mousePosition);   
        mousePose.z = 0;
        transform.right = mousePose;

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(ProjectilePrefab,SpawnPoint.position,Quaternion.identity);
        }
    }
}
