using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public TMP_Dropdown flowerName1;
    public TMP_Dropdown flowerName2;
    public TMP_Dropdown flowerName3;
    private Button startButton;
    public  Button endButton;
    void Start()
    {
        //abstraction
        FlowerInitialisation();
    }

    void FlowerInitialisation()
    {
        //Initialisation
        startButton = GetComponentInChildren<Button>();
        flowerName1.value = 0;
        flowerName2.value = 0;
        flowerName3.value = 0;
        //Add listener for when the selected flower changes
        flowerName1.onValueChanged.AddListener(delegate {
            GetFlower1();
        });
        flowerName2.onValueChanged.AddListener(delegate {
            GetFlower2();
        });
        flowerName3.onValueChanged.AddListener(delegate {
            GetFlower3();
        });
        //Add Listener for Starting and ending the game
        startButton.onClick.AddListener(StartGame);
        endButton.onClick.AddListener(EndGame);
    }

    void GetFlower1()
    {
        GameManager.Instance.flower1 = flowerName1.GetComponentInChildren<TMP_Text>().text;  
    }
    void GetFlower2()
    {
        GameManager.Instance.flower2 = flowerName2.GetComponentInChildren<TMP_Text>().text;

    }
    void GetFlower3()
    {
        GameManager.Instance.flower3 = flowerName3.GetComponentInChildren<TMP_Text>().text;
    }
    void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    void EndGame()
    {
        Application.OpenURL("https://hypnose-und-ablenkung.at");
        Application.Quit();
    }
    

}
