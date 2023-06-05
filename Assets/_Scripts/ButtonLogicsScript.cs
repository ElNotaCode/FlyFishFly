using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLogicsScript : MonoBehaviour
{

    public GameObject soundButtonMute;

    public void OnTryAgainClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene("FlyScene", LoadSceneMode.Single);
    }

    public void OnQuitGameClick()
    {
        Application.Quit();
    }

    public void OnSoundButtonClick()
    {
        if(PlayerPrefs.GetInt("musicMute") == 1)
        {
            PlayerPrefs.SetInt("musicMute", 0);
            soundButtonMute.SetActive(true);
        }
        else
        {
            PlayerPrefs.SetInt("musicMute", 1);
            soundButtonMute.SetActive(false);
        }
        
    }

}
