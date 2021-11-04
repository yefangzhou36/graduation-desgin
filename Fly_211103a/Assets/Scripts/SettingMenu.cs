using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{
    public static bool optionIsOpen = false;
    public GameObject mainMenuUI;
    public GameObject optionMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (optionMenuUI.activeSelf)
        {
            optionIsOpen = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (optionIsOpen == true)
            {
                optionIsOpen = false;
                mainMenuUI.SetActive(true);
                optionMenuUI.SetActive(false);
            }
        }
    }

    public void BackToMain()
    {
        mainMenuUI.SetActive(true);
        optionMenuUI.SetActive(false);
    }
}
