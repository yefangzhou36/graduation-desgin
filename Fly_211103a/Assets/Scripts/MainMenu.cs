using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject optionMenuUI;

    void Start()
    {
        mainMenuUI.SetActive(true);
        optionMenuUI.SetActive(false);
    }

    // Update is called once per frame

    public void LoadGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Debug.Log("quit!");
        Application.Quit();
    }

    public void LoadOption()
    {
        mainMenuUI.SetActive(false);
        optionMenuUI.SetActive(true);
    }
}
