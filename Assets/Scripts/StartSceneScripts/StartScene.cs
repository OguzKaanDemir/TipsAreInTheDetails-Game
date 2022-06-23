using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
   public void EnterBtn()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ExitBtn()
    {
        Application.Quit();
    }
}
