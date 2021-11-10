using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flower3Property : FlowerProperties
{
    public TMP_Text flower3Name;
    public TMP_Text flower3Property;
    private Texture flowerTexture;

    private void Awake()
    {
        flowerProperty = GameObject.Find("Flower Property");
        InitDictionary();
        flowerTexture = Resources.Load<Texture2D>("FlowerSprites/" + GameManager.Instance.flower3);
        ChangeFlowerTexture(flowerTexture);

    }


    public override TMP_Text FlowerName()
    {
        flower3Name.text=GameManager.Instance.flower3;
        return flower3Name;
    }
    public override TMP_Text FlowerSpecificProperties()
    {
        flower3Property.text = FlowerSpecifics(GameManager.Instance.flower3);
        return flower3Property;
    }
    private void OnMouseOver()
    {
        FlowerContainerOn();
        FlowerName();
        FlowerSpecificProperties();
    }
    private void OnMouseExit()
    {
        FlowerContainerOff();
    }

}
