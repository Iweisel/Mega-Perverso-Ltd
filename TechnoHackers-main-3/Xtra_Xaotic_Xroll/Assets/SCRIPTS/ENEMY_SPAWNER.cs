using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ENEMY_SPAWNER : MonoBehaviour
{
    public GameObject enemyprefab;
    public GameObject tankEnemyprefab;
    public float generationTime = 5f;
    public int waveRound;
    public Slider slider;
    public float vaciar;
    public float aparecer;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateEnemy", 0f, generationTime);
        InvokeRepeating("GenerateTank", 2f, generationTime);
        slider.value-= vaciar/10*Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void GenerateEnemy()
    {
        // Generar el enemigo en la posición del spawner
        Instantiate(enemyprefab, transform.position, Quaternion.identity);
    }
    public void GenerateTank()
    {
        Instantiate(tankEnemyprefab, transform.position, Quaternion.identity);
    }

        IEnumerator reaparecer()
    {
        slider.gameObject.SetActive(false);
        yield return new WaitForSeconds(aparecer);
        slider.gameObject.SetActive(true);
    }
}
