using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //encapsulation
    public static GameManager Instance { get; private set; }
    public string flower1;
    public string flower2;
    public string flower3;
    public bool isActive = false;
    public bool winGame = false;
    public bool looseGame = false;
    public bool basket1IsFull = false;
    public bool basket2IsFull = false;
    public bool basket3IsFull = false;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
   

}
