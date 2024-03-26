using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuutonInGame : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
