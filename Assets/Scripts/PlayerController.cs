using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float cameraZDistance;
    public GameObject winGame;
    public GameObject looseGame;

   

   
    private void Start()
    {
        //abstraction
        InitGamePlay();
    }
    private void Update()
    {
       //abstraction
        LooseGame();
    }
    private void OnMouseUp()
    {
        //abstraction
        ActivateGravity();
       
    }

    private void OnMouseDrag()
    {
        //abstraction
        MoveFlower();
       
    }
    void LooseGame()
    {
        if (gameObject.transform.position.y < 0)
        {
            looseGame.SetActive(true);
            GameManager.Instance.isActive = false;
            Destroy(gameObject);
        }
    }
    void MoveFlower()
    {
        //move flower with mousedrag
        if (GameManager.Instance.isActive == true)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance);
            Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objectPosition;
        }
    }
    void ActivateGravity()
    {
        //activate gravity of flower when released
        if (GameManager.Instance.isActive == true)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;

        }

    }
    void InitGamePlay()
    {
        GameManager.Instance.isActive = true;
        winGame.SetActive(false);
        looseGame.SetActive(false);

        //calculate the  world y-screen distance from the origin of the camera to the flower
        cameraZDistance = Camera.main.WorldToScreenPoint(transform.position).z;
    }


}
