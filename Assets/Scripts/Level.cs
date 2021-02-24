using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    //config
    [SerializeField] float sceneDelayInSeceonds = 2f;

    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
        
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Level1");
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene("Start Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(sceneDelayInSeceonds);
        SceneManager.LoadScene("Game Over");
    }
}
