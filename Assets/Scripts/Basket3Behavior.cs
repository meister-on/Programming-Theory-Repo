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
            //abstraction
            ShowTextAndCount();
            Destroy(collision.gameObject);
            //inheritance
            PlayFlowerDropSound();
        }
        if (!collision.gameObject.CompareTag("Flower3"))
        {
            //abstraction
            ShowWarningText();
            PlayFlowerWrongDropSound();
        }

    }
    void ShowTextAndCount()
    {
        //inheritance
        flowerCountText.text = GameManager.Instance.flower3 + ": " + FlowerCounter(ref flower3Count);
        //ends game when all 3 baskets are full of the right flowers
        if (flower3Count == 5)
        {
            GameManager.Instance.basket3IsFull = true;
        }

    }
    void ShowWarningText()
    {
        flower3Name.color = Color.red;
        flower3Name.text = "this is not a " + GameManager.Instance.flower3 + "!";
        StartCoroutine(TextTimer());
    }
    IEnumerator TextTimer()
    {
        yield return new WaitForSeconds(2f);
        flower3Name.color = Color.white;
        flower3Name.text = GameManager.Instance.flower3 + "-Basket";
    }
}
