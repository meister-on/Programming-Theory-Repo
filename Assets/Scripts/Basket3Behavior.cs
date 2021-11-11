using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Basket3Behavior : BasketBehavior
{
    public TMP_Text flower3Name;
    public TMP_Text flowerCountText;
    private static int flower3Count;
    // Start is called before the first frame update
    private void Start()
    {
        flower3Count = 0;
        flower3Name.text = GameManager.Instance.flower3+ "-Basket";
        flowerCountText.text = GameManager.Instance.flower3 + ": " + flower3Count;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Flower3")== true && gameObject.CompareTag("Flower3")==true)
        {
            flowerCountText.text = GameManager.Instance.flower3 + ": " + FlowerCounter(ref flower3Count);
            Destroy(collision.gameObject);
        }
       
    }
}
