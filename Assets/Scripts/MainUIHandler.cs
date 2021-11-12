using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainUIHandler : MonoBehaviour
{
    public Button backButton;
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(BackToStart);
    }

    // Update is called once per frame
   void BackToStart()
    {
        SceneManager.LoadScene(0);
    }
}
