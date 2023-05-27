using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLogicsScript : MonoBehaviour
{
    public void OnTryAgainClick()
    {
        //TODO: mirar bien
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnStartClick()
    {
        SceneManager.LoadScene("FlyScene", LoadSceneMode.Single);
    }

}
