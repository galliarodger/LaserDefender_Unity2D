using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2f;

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1); //can also use a string reference but that sucks
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGameOver()
    {

        StartCoroutine(WaitAndLoad());
        SceneManager.LoadScene(2);
    }

    private IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene(2);

    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}
