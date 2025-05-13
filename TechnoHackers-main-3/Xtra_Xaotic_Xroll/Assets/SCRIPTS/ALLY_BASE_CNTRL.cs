using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BASE_CNTRL : MonoBehaviour
{
    public Slider Allyhealth;
    public Slider Enemyhealth;
    // Start is called before the first frame update
    void Start()
    {
        Allyhealth.value = 100;
        Enemyhealth.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ENEMY")
        {
            Allyhealth.value -=5f;

        }
        if (collision.gameObject.tag == "ALLY")
        {
            Enemyhealth.value -= 5f;

        }
    }
}
