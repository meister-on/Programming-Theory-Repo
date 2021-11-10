using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flower1Property : FlowerProperties
{
    public TMP_Text flower1Name;
    public TMP_Text flower1Property;
    private Texture flowerTexture;

    private void Awake()
    {
        flowerProperty = GameObject.Find("Flower Property");
        InitDictionary();
        flowerTexture = Resources.Load<Texture2D>("FlowerSprites/"+GameManager.Instance.flower1);
        ChangeFlowerTexture(flowerTexture);

    }
    private void Start()
    {
       
        flowerProperty.SetActive(false);
       

    }
    public override TMP_Text FlowerName()
    {
        flower1Name.text=GameManager.Instance.flower1;
        return flower1Name;
    }
    public override TMP_Text FlowerSpecificProperties()
    {
        flower1Property.text = FlowerSpecifics(GameManager.Instance.flower1);
        return flower1Property;
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
