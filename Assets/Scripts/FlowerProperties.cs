using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public abstract class FlowerProperties : MonoBehaviour
{
    
    protected GameObject flowerProperty;
    public abstract TMP_Text FlowerName();
    public abstract TMP_Text FlowerSpecificProperties();
   
    public void FlowerContainerOn()
    {
        flowerProperty.SetActive(true);
    }
    public void FlowerContainerOff()
    {
        flowerProperty.SetActive(false);
    }
    public void FlowerLifeDuration(float lifeTime)
    {
        Destroy(gameObject, lifeTime);
    }

}
