using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public abstract class FlowerProperties : MonoBehaviour
{
    
    protected GameObject flowerProperty;
    public abstract TMP_Text FlowerName();
    public abstract TMP_Text FlowerSpecificProperties();
    protected Dictionary<string,string> flowerDictionary = new Dictionary<string, string>();
  

    public void FlowerContainerOn()
    {
        if(GameManager.Instance.isActive == true)
        {
            flowerProperty.SetActive(true);
        }

    }
    public void FlowerContainerOff()
    {
        flowerProperty.SetActive(false);
    }
    public void FlowerLifeDuration(float lifeTime)
    {
        Destroy(gameObject, lifeTime);
    }
    public void InitDictionary()
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
   
    public string FlowerSpecifics(string flower)
    {
        string flowerProperty= (string)flowerDictionary[flower];
        return flowerProperty;
       
    }
    public virtual void ChangeFlowerTexture(Texture flower)
    {
        MeshRenderer flowerMeshRenderer = GetComponent<MeshRenderer>();
        flowerMeshRenderer.material.SetTexture("_MainTex",flower);
    }

}
