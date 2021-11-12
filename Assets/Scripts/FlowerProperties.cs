using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//inheritance
//Base Class for Flower Properties
public abstract class FlowerProperties : MonoBehaviour
{
    //encapsulation
    protected GameObject flowerProperty;
    //abstraction
    //polymorphism
    public abstract TMP_Text FlowerName();
    //abstraction
    //polymorphism
    public abstract TMP_Text FlowerSpecificProperties();
    //encapsulation
    protected Dictionary<string,string> flowerDictionary = new Dictionary<string, string>();
  

    public void FlowerContainerOn()
    {
        if(GameManager.Instance.isActive == true)
        {
            flowerProperty.SetActive(true);
        }

    }
    //encapsulation
    protected void FlowerContainerOff()
    {
        flowerProperty.SetActive(false);
    }
    //encapsulation
    protected void FlowerLifeDuration(float lifeTime)
    {
        Destroy(gameObject, lifeTime);
    }
    //encapsulation
    protected void InitDictionary()
    {
        flowerDictionary.Clear();
        flowerDictionary.Add("Aconite", "Properties of Aconite");
        flowerDictionary.Add("Calendula", "Properties of Calendula");
        flowerDictionary.Add("Daffodil", "Properties of Daffodil");
        flowerDictionary.Add("Pansy", "Properties of Pansy");
        flowerDictionary.Add("Violet", "Properties of Violet");
        flowerDictionary.Add("Tulip", "Properties of Tulip");
        flowerDictionary.Add("Daisy", "Properties of Daisy");
        flowerDictionary.Add("Foxglove", "Properties of Foxglov");
        flowerDictionary.Add("Rose", "Properties of Rose");
        flowerDictionary.Add("Lily", "Properties of Lily");
        flowerDictionary.Add("Dandelion", "Properties of Dandelion");
        flowerDictionary.Add("Poppy", "Properties of Poppy");
    }
    //encapsulation
    //polymorphism
    protected string FlowerSpecifics(string flower)
    {
        string flowerProperty= (string)flowerDictionary[flower];
        return flowerProperty;
       
    }
    //polymorphism
    //encapsulation
    protected virtual void ChangeFlowerTexture(Texture flower)
    {
        MeshRenderer flowerMeshRenderer = GetComponent<MeshRenderer>();
        flowerMeshRenderer.material.SetTexture("_MainTex",flower);
    }

}
