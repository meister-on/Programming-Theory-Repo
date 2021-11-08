using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket2Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Flower2")== true && gameObject.CompareTag("Flower2")==true)
        {
            Destroy(collision.gameObject);
        }
       
    }
}
