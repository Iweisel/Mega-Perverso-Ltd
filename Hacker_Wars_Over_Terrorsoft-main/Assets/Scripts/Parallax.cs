using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class ParallaxMovement : MonoBehaviour
{
    Transform cam; //Main Camera
    Vector3 camStartPos;
    float distance;

    GameObject[] backgrounds;
    Material[] mat;
    float[] backSpeed;

    float[] farthestBack;

    [Range(0.01f, 0.05f)]
    public float parallaxSpeed;
    void Start()
    {
        cam = Camera.main.transform;
        camStartPos = cam.position;

        int backCount = transform.childCount;
        mat = new Material[backCount];
        backSpeed = new float[backCount];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
