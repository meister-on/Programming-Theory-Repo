using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject winGame;
    private float cameraSpeed = 10;
    private float forwardMovementCamera;
    private void Start()
    {
        winGame.SetActive(false);
    }
    private void Update()
    {
        //abstraction
        MoveCamera();
      
        //abstraction
        WinGameCheck();       
    }
    // Start is called before the first frame update
    public void RestartGame()
    {
        winGame.SetActive(false);
        SceneManager.LoadScene(1);
    }
    void MoveCamera()
    {
        if (GameManager.Instance.isActive)
        {
            forwardMovementCamera = Input.GetAxis("Vertical");
            if (Camera.main.transform.position.z > 181)
            {
                Camera.main.transform.position = new Vector3(0, 18, 181);
            }
            if (Camera.main.transform.position.z < 0)
            {
                Camera.main.transform.position = new Vector3(0, 18, 0);
            }

            Camera.main.transform.Translate(0, forwardMovementCamera * cameraSpeed * Time.deltaTime, 0);
        }
       
    }
    void WinGameCheck()
    {
        if (GameManager.Instance.basket1IsFull && GameManager.Instance.basket2IsFull && GameManager.Instance.basket3IsFull)
        {
            winGame.SetActive(true);
            GameManager.Instance.isActive = false;
            GameManager.Instance.basket1IsFull = false;
            GameManager.Instance.basket2IsFull = false;
            GameManager.Instance.basket3IsFull = false;

        }
    }
}
