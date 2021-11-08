using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flower2Property : FlowerProperties
{
    public TMP_Text flower2Name;
    public TMP_Text flower2Property;
    private void Awake()
    {
        flowerProperty = GameObject.Find("Flower Property");
        InitDictionary();
    }
   
    public override TMP_Text FlowerName()
    {
        flower2Name.text=GameManager.Instance.flower2;
        return flower2Name;
    }
    public override TMP_Text FlowerSpecificProperties()
    {
        flower2Property.text = FlowerSpecifics(GameManager.Instance.flower2);
        return flower2Property;
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
