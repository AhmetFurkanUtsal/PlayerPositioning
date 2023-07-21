using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    // dizi oluşturduk. ardından hayvanları dizinin içine sürükleyip bıraktık.
    // Start is called before the first frame update

    //public int animalIndex;

    private float spawnRangeX = 20;
    private float spawnPosY = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {










       /* if (Input.GetKeyDown(KeyCode.S))
        {

            
            SpawnRandomAnimal();
            

           // int animalIndex = Random.Range(0, animalPrefabs.Length);

            // değikenimizi sadece burada kullanmak için taşıdık
            // Range ifadesi seçilen ilk sayı ile son sayı arasında seçim yapar. 0 dan başlayarak 1 , 2 sayarak bitecektir

            //int animalIndex = Random.Range(0, 3);
            // ancak üçü kullanmayacaktır. 
            // animalPrefabs.Length dizi sayısı

            //Vector3 spawnPos = new Vector3 (Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosY);

            //Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-20,20), 0, 20), animalPrefabs[animalIndex].transform.rotation);

           // Instantiate(animalPrefabs[animalIndex],spawnPos, animalPrefabs[animalIndex].transform.rotation);
           
            
        }
        */
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // değikenimizi sadece burada kullanmak için taşıdık
        // Range ifadesi seçilen ilk sayı ile son sayı arasında seçim yapar. 0 dan başlayarak 1 , 2 sayarak bitecektir

        //int animalIndex = Random.Range(0, 3);
        // ancak üçü kullanmayacaktır. 
        // animalPrefabs.Length dizi sayısı

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosY);

        //Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-20,20), 0, 20), animalPrefabs[animalIndex].transform.rotation);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
