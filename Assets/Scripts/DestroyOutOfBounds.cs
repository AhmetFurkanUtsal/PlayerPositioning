using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public float topBound = 30;
    public float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Oyun Bitti");
            Destroy(gameObject);
            //DestroyOutOfBounds.cs'de, hayvanların ekranın alt kısmına ulaşıp ulaşmadığını
            //kontrol eden else-if durumunda bir Game Over mesajı ekleyin:
        }
    }
}
