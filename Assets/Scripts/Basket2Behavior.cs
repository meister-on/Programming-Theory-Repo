using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Basket2Behavior : MonoBehaviour
{
    public TMP_Text flower2Name;
    // Start is called before the first frame update
    private void Start()
    {
        flower2Name.text = GameManager.Instance.flower2 + "-Basket";
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Flower2")== true && gameObject.CompareTag("Flower2")==true)
        {
            Destroy(collision.gameObject);
        }
       
    }
}
