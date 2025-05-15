using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALLY_SPAWNER : MonoBehaviour
{
    public GameObject allyprefab;
    public GameObject chozaPrefab;
    int chozaCount;
    PLAYER_MOVEMENT pm;
    // Start is called before the first frame update
    void Start()
    {
        pm = FindAnyObjectByType<PLAYER_MOVEMENT>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GenerateAlly(int type) //Genera aliados y chozas
    {
        switch (type)
        {
            case 0:
                if (pm._dropCount >= 20) // Necesita 20 monedas para sacar un aliado
                {
                    Instantiate(allyprefab, transform.position, Quaternion.identity); // Generar el enemigo en la posición del spawner
                    pm._dropCount -= 20; //te quita 20 monedas
                }
                break;
            case 1:
                if (pm.woodCount >= 5) // Necesita 5 de madera para sacar una choza
                {
                    chozaCount++; //añade una choza mas 
                    float posX = Random.Range(1.5f*chozaCount,5*chozaCount); //cambia la posicion de la siguiente choza para que no colapse
                    Vector3 chozaPos = new Vector3(transform.position.x+posX,transform.position.y,transform.position.z); //ajusta la posicion de la choza
                    Instantiate(chozaPrefab, chozaPos, Quaternion.identity); // Generar el enemigo en la posición del spawner
                    pm.woodCount -= 5; // Te quita 5 de madera
                }
                break;
        }
    }
}