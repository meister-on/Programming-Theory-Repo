using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FlowerProperties : MonoBehaviour
{
    private GameObject flowerProperty;
    private string m_flowerName;
    public string flowerName
    { get {
            flowerName = m_flowerName;
        }
        set
        {

        } 
    }
    private void Start()
    {
        flowerProperty = GameObject.Find("Flower Property");
    }
    public void FlowerLifeDuration(float lifeTime)
    { 
        Destroy(gameObject, lifeTime);
    }
    public abstract string FlowerSpecificProperties();
    public virtual void ContainerFlowerInfo()
    {
        flowerProperty.SetActive(true);
    }
    
}
