using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject winGame;
    public float cameraSpeed = 5;
    public float forwardMovementCamera;
    private void Start()
    {
        winGame.SetActive(false);
    }
    private void Update()
    {
        if (GameManager.Instance.isActive)
        {
            MoveCamera();
        }


        if (GameManager.Instance.basket1IsFull && GameManager.Instance.basket2IsFull && GameManager.Instance.basket3IsFull)
        {
            winGame.SetActive(true);
            GameManager.Instance.isActive = false;
            GameManager.Instance.basket1IsFull = false;
            GameManager.Instance.basket2IsFull = false;
            GameManager.Instance.basket3IsFull = false;

        }
    }
    // Start is called before the first frame update
    public void RestartGame()
    {
        winGame.SetActive(false);
        SceneManager.LoadScene(1);
    }
    void MoveCamera()
    {
        forwardMovementCamera = Input.GetAxis("Vertical");
        if(Camera.main.transform.position.z > 181)
        {
            Camera.main.transform.position = new Vector3(0,18,181);
        }
        if (Camera.main.transform.position.z < 0)
        {
            Camera.main.transform.position = new Vector3(0, 18, 0);
        }

        Camera.main.transform.Translate(0, forwardMovementCamera * cameraSpeed * Time.deltaTime, 0);
    }
}
