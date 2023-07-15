using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenejer : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameISPaused = false;
    public GameObject PauseMeniuUi;
    
    public void Pausee()
    {
        if (GameISPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
    public void Pause()
    {
        PauseMeniuUi.SetActive(true);
        Time.timeScale = 0f;
        GameISPaused = true;
        //SaveSystem.SavePalyer(this);
    }
    public void Resume()
    {
        PauseMeniuUi.SetActive(false);
        Time.timeScale = 1f;
        GameISPaused = false;
    }
    // Update is called once per frame
    public void Resume2()
    {
        PauseMeniuUi.SetActive(false);
        Time.timeScale = 1f;
        GameISPaused = false;
        SceneManager.LoadScene(2);
    }
    public void Resume3()
    {
        PauseMeniuUi.SetActive(false);
        Time.timeScale = 1f;
        GameISPaused = false;
        
    }
}
