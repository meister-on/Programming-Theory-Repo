using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//inheritance
//Base Class for Basket Behavior
public class BasketBehavior : MonoBehaviour
{   
    protected int FlowerCounter(ref int flower)
    {
        flower++;
        return flower;
    }
    
}
