using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;

public class Olla_cntrl : MonoBehaviour
{
    public GameObject sopa;
    public Slider timeslider;
    public GameObject bullet;
    public RNG_Controller controller;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {        
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("asdokvnados´knv");
            controller.BulletCollisionOnSoup();
        }
    }
}
