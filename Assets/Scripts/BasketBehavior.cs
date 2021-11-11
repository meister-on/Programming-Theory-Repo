using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBehavior : MonoBehaviour
{
    //protected static int flower=0;
    
    public int FlowerCounter(ref int flower)
    {
        flower++;
        return flower;
    }
    
}
