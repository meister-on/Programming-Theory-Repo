using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject winGame;
    private void Start()
    {
        winGame.SetActive(false);
    }
    private void Update()
    {

        if(GameManager.Instance.basket1IsFull && GameManager.Instance.basket2IsFull && GameManager.Instance.basket3IsFull)
        {
            winGame.SetActive(true);
            GameManager.Instance.isActive = false;
        }
    }
    // Start is called before the first frame update
    public void RestartGame()
    {
        winGame.SetActive(false);
        SceneManager.LoadScene(1);
    }
}
