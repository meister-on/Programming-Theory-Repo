using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Basket1Behavior : BasketBehavior
{
    public TMP_Text flower1Name;
    public TMP_Text flowerCountText;
    private static int flower1Count;
    // Start is called before the first frame update
    private void Start()
    {
        flower1Count = 0;
        flower1Name.text = GameManager.Instance.flower1 + "-Basket";
        flowerCountText.text = GameManager.Instance.flower1 + ": " + flower1Count;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Flower1") == true && gameObject.CompareTag("Flower1") == true)
        {
            //abstraction
            ShowTextAndCount();
            Destroy(collision.gameObject);
            //inheritance
            PlayFlowerDropSound();
        }
        if (!collision.gameObject.CompareTag("Flower1"))
        {
            //abstraction
            ShowWarningText();
            PlayFlowerWrongDropSound();
        }
    }
   void ShowTextAndCount()
    {
        //inheritance
        flowerCountText.text = GameManager.Instance.flower1 + ": " + FlowerCounter(ref flower1Count);
        //ends game when all 3 baskets are full of the right flowers
        if (flower1Count == 5)
        {
            GameManager.Instance.basket1IsFull = true;
        }
        
    }
    void ShowWarningText()
    {
        flower1Name.color = Color.red;
        flower1Name.text = "this is not a " + GameManager.Instance.flower1 + "!";
        StartCoroutine(TextTimer());
    }
    IEnumerator TextTimer()
    {
        yield return new WaitForSeconds(2f);
        flower1Name.color = Color.white;
        flower1Name.text = GameManager.Instance.flower1 + "-Basket";
    }
   
}
