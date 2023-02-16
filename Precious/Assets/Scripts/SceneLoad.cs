using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{

    public GameObject pausemenu;

    public void PlayMenu()
    {
        SceneManager.LoadScene("PlayMenu");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void FirstMap()
    {
        SceneManager.LoadScene("FirstMap");
    }
    public void SecondMap()
    {
        SceneManager.LoadScene("SecondMap");
    }
    public void ThirdMap()
    {
        SceneManager.LoadScene("ThirdMap");
    }
    public void MapFour()
    {
        SceneManager.LoadScene("4thMap");
    }
    public void MapFive()
    {
        SceneManager.LoadScene("5thMap");
    }
    public void MapSix()
    {
        SceneManager.LoadScene("6thMap");
    }
    public void MapSeven()
    {
        SceneManager.LoadScene("7thMap");
    }
    public void MapEight()
    {
        SceneManager.LoadScene("8thMap");
    }
    
    public void Playy()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
