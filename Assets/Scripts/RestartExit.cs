using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartExit : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Gravity");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
