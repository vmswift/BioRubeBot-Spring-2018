using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string nextScene;
    public string homeMenuScene;

    //Restart current scene
    public void restartbutton()
    {
        //SceneManager.LoadScene(Application.loaddedLevel);
        Application.LoadLevel(Application.loadedLevel);
        GameWon.Set_WinConditions();
    }

    //Load next scene
    public void loadNextScene()
    {
        //Application.LoadLevel(nextScene);
        SceneManager.LoadScene(nextScene);
        GameWon.Set_WinConditions();
    }
    
    public void loadHomeMenu()
    {
        // Application.LoadLevel(homeMenuScene);
        SceneManager.LoadScene(homeMenuScene);
        GameWon.Set_WinConditions();
    }


}