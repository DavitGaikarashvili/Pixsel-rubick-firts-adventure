using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class meniumeneger : MonoBehaviour
{
    // Start is called before the first frame update
    public int loadscene ;
    public int loadaboutscene;
    public int loadmenu;
    void Start()
    {
        
    }
    public void about_the_game()
    {
        SceneManager.LoadScene(loadaboutscene);
    }
    public void back_to_menu()
    {
        SceneManager.LoadScene(loadmenu);
    }


    public void menu()
    {
        SceneManager.LoadScene(loadscene);
        Destroy(gameObject);
    }
    public void dawyeba()
    {
        SceneManager.LoadScene(loadscene);
        //SaveSystem.SavePalyer(this);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void gamosvla()
    {
        Application.Quit();
        //PlayerData data = SaveSystem.loadplayer();
        //koini = data.koini;
    }
}
