using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class movementplayer : MonoBehaviour
{
    public float vel=5f;
    public GameObject suciedad;
    public int money;
    public TextMeshProUGUI moneyscore;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()//Movimiento del personaje de izquierda a derecha
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(horizontal, 0f, vertical) * vel * Time.deltaTime;
        transform.Translate(movimiento, Space.World);

        if (Input.GetMouseButtonDown(0))//Cuando haces click desaparece la suciedad
        { 
           suciedad.SetActive(false);
        
        }
        //if (suciedad != null&& !suciedad.activeSelf)//Cuando le has pulsado en la suciedad cuenta el dinero que ha ganado
        //{
        //}
        if(Input.GetMouseButtonDown(0)&& suciedad!=null)
        {
            GetMoney(20);
        }
    }
    void GetMoney(int value)
    {
            money += value;
            moneyscore.text=money.ToString();
    }
}
