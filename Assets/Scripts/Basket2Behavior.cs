using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Basket2Behavior : BasketBehavior
{
    public TMP_Text flower2Name;
    public TMP_Text flowerCountText;
    private static int flower2Count;
    // Start is called before the first frame update
    private void Start()
    {
        flower2Count = 0;
        flower2Name.text = GameManager.Instance.flower2 + "-Basket";
        flowerCountText.text = GameManager.Instance.flower2 + ": " + flower2Count;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Flower2")== true && gameObject.CompareTag("Flower2")==true)
        {
            flowerCountText.text = GameManager.Instance.flower2 + ": " + FlowerCounter(ref flower2Count);
            //ends game when all 3 baskets are full of the right flowers
            if (flower2Count == 5)
            {
                GameManager.Instance.basket2IsFull = true;
            }
            Destroy(collision.gameObject);
        }
       
    }
}
