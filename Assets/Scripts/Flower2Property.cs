using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//inheritance
//abstraction

public class Flower2Property : FlowerProperties
{
    public TMP_Text flower2Name;
    public TMP_Text flower2Property;
    private Texture flowerTexture;

    private void Awake()
    {
        //inheritance
        flowerProperty = GameObject.Find("Flower Property");
        InitDictionary();
        flowerTexture = Resources.Load<Texture2D>("FlowerSprites/" + GameManager.Instance.flower2);
        ChangeFlowerTexture(flowerTexture);

    }
    //inheritance
    public override TMP_Text FlowerName()
    {
        flower2Name.text=GameManager.Instance.flower2;
        return flower2Name;
    }
    //inheritance
    public override TMP_Text FlowerSpecificProperties()
    {
        flower2Property.text = FlowerSpecifics(GameManager.Instance.flower2);
        return flower2Property;
    }
    //abstraction
    private void OnMouseOver()
    {
        FlowerContainerOn();
        FlowerName();
        FlowerSpecificProperties();
    }
    //abstraction
    private void OnMouseExit()
    {
        FlowerContainerOff();
    }

}
