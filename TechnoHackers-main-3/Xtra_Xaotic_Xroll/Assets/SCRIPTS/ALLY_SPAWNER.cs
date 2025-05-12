using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ALLY_SPAWNER : MonoBehaviour
{
    public Slider slider;
    public GameObject allyprefab;
    public float aparecer;
    public float vaciar;
      PLAYER_MOVEMENT pm;
    // Start is called before the first frame update
    void Start()
    {
        pm = FindAnyObjectByType<PLAYER_MOVEMENT>();
    }

    // Update is called once per frame
    void Update()
    {
      slider.value-= vaciar / 10 * Time.deltaTime;
    }
    public void GenerateAlly()
    {
        if (pm._dropCount >= 20)
        {
            Instantiate(allyprefab, transform.position, Quaternion.identity); // Generar el enemigo en la posición del spawner
            pm._dropCount -= 20;
        }
    }

   IEnumerator reaparecer()
   {
        slider.gameObject.SetActive(false);  
        yield return new WaitForSeconds(aparecer);
        slider.gameObject.SetActive(true);  
   }
}