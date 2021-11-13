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
        flowerDictionary.Add("Aconite", "Aconite or Wolf’s bane signifies caution, treachery, and misanthropy. The flower’s symbolism meant that it was often used as a warning. A gift of wolf’s bane flowers was seen as a symbol to the recipient to take care as danger lies ahead.");
        flowerDictionary.Add("Calendula", "Marigold or Calendula represents winning affection over someone you care about. It also symbolizes a functioning relationship. In the Victorian era, Calendula was seen as a symbol of despair and grief");
        flowerDictionary.Add("Daffodil", "Daffodils are symbols of rebirth and hope. They signify new life and resilience as they are strong little survivors who have weathered the winter storms. They are also a symbol of positivity");
        flowerDictionary.Add("Pansy", "Pansy is best used as a symbol of platonic love. Pansies can also represent free-thinking and consideration.");
        flowerDictionary.Add("Violet", "Violet flower meanings include innocence, everlasting love, modesty, spiritual wisdom, faithfulness, mysticism, and remembrance.");
        flowerDictionary.Add("Tulip", "The meaning of Tulips is perfect and deep love. Tulips also symbolize fame, passion, the perfect lover and romance");
        flowerDictionary.Add("Daisy", "Daisy flower meaning includes new beginnings, hope, innocence, fun, affection, and other sweet attributes.");
        flowerDictionary.Add("Foxglove", "Foxglove is associated with insincerity, pride, intuition, creativity, and energy.");
        flowerDictionary.Add("Rose", "Red rose is a symbol of love and romance, yellow of friendship, orange of enthusiasm, white of purity and pink of joy.");
        flowerDictionary.Add("Lily", "The most common meaning is purity and fertility. The sweet and innocent beauty of the lily flower has given it the association of fresh life and rebirth.");
        flowerDictionary.Add("Dandelion", "Dandelions are a symbol of wealth and prosperity, which is why this flower was often given to someone who had just been married. It also is a symbol of hope, love, and happiness.");
        flowerDictionary.Add("Poppy", "Red poppy flowers represent consolation, remembrance and death. Likewise, the poppy is a common symbol that has been used to represent everything from peace to death and even simply sleep.");
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
