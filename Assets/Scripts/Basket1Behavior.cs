using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Basket1Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Flower1")== true && gameObject.CompareTag("Flower1")==true)
        {
            Destroy(collision.gameObject);
        }
       
    }
}
