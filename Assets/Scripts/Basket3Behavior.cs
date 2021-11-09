using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Basket3Behavior : MonoBehaviour
{
    public TMP_Text flower3Name;
    // Start is called before the first frame update
    private void Start()
    {
        flower3Name.text = GameManager.Instance.flower3+ "-Basket";
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Flower3")== true && gameObject.CompareTag("Flower3")==true)
        {
            Destroy(collision.gameObject);
        }
       
    }
}
