using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Changer : MonoBehaviour
{


    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SampleScene()
    {
        SceneManager.LoadScene(1);
    }



    public void Earth()
    {
        SceneManager.LoadScene(2);
    }

    public void Crust()
    {
        SceneManager.LoadScene(3);
    }

    public void Mantle()
    {
        SceneManager.LoadScene(4);
    }

    public void Core()
    {
        SceneManager.LoadScene(5);
    }

    public void Rotation()
    {
        SceneManager.LoadScene(6);
    }
    public void Layer()
    {
        SceneManager.LoadScene(7);
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
