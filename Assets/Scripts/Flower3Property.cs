using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//inheritance
//abstraction
public class Flower3Property : FlowerProperties
{
    public TMP_Text flower3Name;
    public TMP_Text flower3Property;
    private Texture flowerTexture;

    private void Awake()
    {
        //inheritance
        flowerProperty = GameObject.Find("Flower Property");
        InitDictionary();
        flowerTexture = Resources.Load<Texture2D>("FlowerSprites/" + GameManager.Instance.flower3);
        ChangeFlowerTexture(flowerTexture);

    }

    //inheritance
    public override TMP_Text FlowerName()
    {
        flower3Name.text=GameManager.Instance.flower3;
        return flower3Name;
    }
    //inheritance
    public override TMP_Text FlowerSpecificProperties()
    {
        flower3Property.text = FlowerSpecifics(GameManager.Instance.flower3);
        return flower3Property;
    }
    //inheritance
    //abstraction
    private void OnMouseOver()
    {
        FlowerContainerOn();
        FlowerName();
        FlowerSpecificProperties();
    }
    //inheritance
    //abstraction
    private void OnMouseExit()
    {
        FlowerContainerOff();
    }

}
