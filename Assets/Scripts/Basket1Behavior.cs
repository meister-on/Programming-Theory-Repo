using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Basket1Behavior : MonoBehaviour
{
    public TMP_Text flower1Name;
    // Start is called before the first frame update
    private void Start()
    {
        flower1Name.text = GameManager.Instance.flower1 + "-Basket";
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Flower1")== true && gameObject.CompareTag("Flower1")==true)
        {
            Destroy(collision.gameObject);
        }
       
    }
}
