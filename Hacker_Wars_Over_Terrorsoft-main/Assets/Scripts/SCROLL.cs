using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCROLL : MonoBehaviour
{
    [SerializeField] private float speed = 2.5f;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.left * speed;
    }
}
    // Update is called once per frame
    
