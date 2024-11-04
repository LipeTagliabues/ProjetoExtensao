using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhasesSceneController : MonoBehaviour
{
    //SAIR DAS FASES
    
    public void QuitGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MenuGame()
    {
        SceneManager.LoadScene(0);
    }

    //MENU PRINCIPAL
    public void StartGame1()
    {
        SceneManager.LoadScene(2);
    }
    public void StartGame2()
    {
        SceneManager.LoadScene(3);
    }
    public void StartGame3()
    {
        SceneManager.LoadScene(4);
    }
    public void StartGame4()
    {
        SceneManager.LoadScene(5);
    }
    public void StartGame5()
    {
        SceneManager.LoadScene(6);
    }
    public void StartGame6()
    {
        SceneManager.LoadScene(7);
    }
    
    //FALA
    public void AdvanceSpeak()
    {
        SceneManager.LoadScene(9);
    }
    public void AdvanceSpeak1()
    {
        SceneManager.LoadScene(10);
    }
    public void AdvanceSpeak2()
    {
        SceneManager.LoadScene(1);
    }
}

