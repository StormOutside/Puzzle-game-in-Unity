using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public GameObject pausePanel;
    public AudioSource audioGame;
    string activeScene;
    public Button nextButton;
    public GameObject aboutPanel;
    private void Start()
    {
        Time.timeScale = 1;
        activeScene = SceneManager.GetActiveScene().name;
        if(activeScene == "3x3 Pazzle 8")
        {
            nextButton.interactable = false;
        }
        if(activeScene == "Main Menu")
        {
            aboutPanel.SetActive(false);
        }
        
    }
    public void ClickButtonStart()
    {
        SceneManager.LoadScene("Selection of The Number Pazzle 3x3");
    }
  
    public void ClickButton4x4PazzleSize()
    {
        SceneManager.LoadScene("Selection of The Number  Pazzle 4x4");
    }
    public void ClickToButtonNumberOfPazzle1()
    {
        SceneManager.LoadScene("3x3 Pazzle 1");
    }
    public void ClickToButtonNumberOfPazzle2()
    {
        SceneManager.LoadScene("3x3 Pazzle 2");
    }
    public void ClickToButtonNumberOfPazzle3()
    {
        SceneManager.LoadScene("3x3 Pazzle 3");
    }
    public void ClickToButtonNumberOfPazzle4()
    {
        SceneManager.LoadScene("3x3 Pazzle 4");
    }
    public void ClickToButtonNumberOfPazzle5()
    {
        SceneManager.LoadScene("3x3 Pazzle 5");
    }
    public void ClickToButtonNumberOfPazzle6()
    {
        SceneManager.LoadScene("3x3 Pazzle 6");
    }
    public void ClickToButtonNumberOfPazzle7()
    {
        SceneManager.LoadScene("3x3 Pazzle 7");
    }
    public void ClickToButtonNumberOfPazzle8()
    {
        SceneManager.LoadScene("3x3 Pazzle 8");
    }
    public void ClickToButtonBackinSelectionNumberPazzle3x3()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void ClickToButtonPauseInGame()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        audioGame.Pause();
    }
    public void ClickToContinueButton()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        audioGame.Play();
    }
    public void ClickToMainMenuButtonInPauseMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
   
    public void ClickToButtonMainMenuInCompPazPan()
    {
        
        SceneManager.LoadScene("Main Menu");
        
    }
    public void ClickToButtonChoicePazInCompPazPan()
    {
        
        SceneManager.LoadScene("Selection of The Number Pazzle 3x3");

    }
    public void ClickToButtonNextInCimpPazPan()
    {
        if(activeScene == "3x3 Pazzle 1")
        {
            SceneManager.LoadScene("3x3 Pazzle 2");
        }
        if (activeScene == "3x3 Pazzle 2")
        {
            SceneManager.LoadScene("3x3 Pazzle 3");
        }
        if (activeScene == "3x3 Pazzle 3")
        {
            SceneManager.LoadScene("3x3 Pazzle 4");
        }
        if (activeScene == "3x3 Pazzle 4")
        {
            SceneManager.LoadScene("3x3 Pazzle 5");
        }
        if (activeScene == "3x3 Pazzle 5")
        {
            SceneManager.LoadScene("3x3 Pazzle 6");
        }
        if (activeScene == "3x3 Pazzle 6")
        {
            SceneManager.LoadScene("3x3 Pazzle 7");
        }
        if (activeScene == "3x3 Pazzle 7")
        {
            SceneManager.LoadScene("3x3 Pazzle 8");
        }
    }
    public void ClickToButtonAbout()
    {
        aboutPanel.SetActive(true);
    }
    public void ClickToCloseAboutPanel()
    {
        aboutPanel.SetActive(false);
    }
    public void ClickToButtonExit()
    {
        Application.Quit();
    }
}
