using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket3Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Flower3")== true && gameObject.CompareTag("Flower3")==true)
        {
            Destroy(collision.gameObject);
        }
       
    }
}
