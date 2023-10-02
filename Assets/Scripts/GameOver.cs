using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void GameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
