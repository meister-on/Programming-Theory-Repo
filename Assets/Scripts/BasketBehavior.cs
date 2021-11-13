using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//inheritance
//Base Class for Basket Behavior
public class BasketBehavior : MonoBehaviour
{
    private AudioSource flowerDropSound;
    private AudioSource flowerWrongDropSound;
    private void Awake()
    {
        flowerDropSound = GameObject.Find("FlowerDropSound").GetComponent<AudioSource>();
        flowerWrongDropSound = GameObject.Find("FlowerWrongDropSound").GetComponent<AudioSource>();
    }
    protected int FlowerCounter(ref int flower)
    {
        flower++;
        return flower;
    }
    protected void PlayFlowerDropSound()
    {
        flowerDropSound.Play();
    }
    protected void PlayFlowerWrongDropSound()
    {
        flowerWrongDropSound.Play();
    }
}
