using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float cameraZDistance;

   
    private void Start()
    {
        //calculate the  world y-screen distance from the origin of the camera to the flower
        cameraZDistance = Camera.main.WorldToScreenPoint(transform.position).z;
    }
    private void OnMouseUp()
    {
       //activate gravity of flower when released
        gameObject.GetComponent<Rigidbody>().useGravity = true;
       
    }

    private void OnMouseDrag()
    {
        //move flower with mousedrag
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cameraZDistance);
        Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objectPosition;
    }
   
}
