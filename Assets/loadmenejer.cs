using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class loadmenejer : MonoBehaviour
{
    public GameObject loadingScreen;
    public GameObject loadgamesettings;
    public GameObject loadabottgame;
    public GameObject loadsecretinfo;
    public GameObject dasawyisi;
    public GameObject dasawyisi2;
    public Slider slider;
    public TextMeshProUGUI TextMeshProUGUI;
    public void secretinfo_game()
    {
        loadsecretinfo.SetActive(true);
    }
    public void secretinfo_game_back()
    {
        loadsecretinfo.SetActive(false);
    }
    public void setting_game()
    {
        loadgamesettings.SetActive(true);
    }
    public void setting_game_back()
    {
        loadgamesettings.SetActive(false);
    }
    public void about_game()
    {
        loadabottgame.SetActive(true);
    }
    public void about_game_back()
    {
        loadabottgame.SetActive(false);
    }
    public void LoadLevel ()
    {
        //StartCoroutine(LoadAsynchronously(sceneIndex));
        dasawyisi.SetActive(false);
        dasawyisi2.SetActive(true);
    }
    public void LoadLeveli(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }
        
        IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 17f);
            //slider.value = progress;
            //TextMeshProUGUI.text = progress * + 100f + "%";
            yield return null;
        }
    }
}
