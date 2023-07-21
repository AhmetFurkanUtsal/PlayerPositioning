using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        //bir nesnenin başka bir nesnenin çarpışma alanına girdiğinde çağrılır.
        //Koddaki Destroy işlevi, verilen nesneyi yok eder. Bu durumda, kod iki nesneyi de yok eder.
    }
}
