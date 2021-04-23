using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{
    public void LoadSceneSingle(int level)
    {
        SceneManager.LoadScene(level, LoadSceneMode.Single);
    }
    
    public void LoadSceneAdditive(int level)
    {
        if (level == 2)
        {
            GameObject[] pieces;
            pieces = GameObject.FindGameObjectsWithTag("Pieces");
            foreach (GameObject element in pieces)
            {
                element.GetComponent<Box>().enabled = false;
            }
        }
        SceneManager.LoadScene(level, LoadSceneMode.Additive);
    }

    public void UnloadScene(int level)
    {
        GameObject[] pieces;
        pieces = GameObject.FindGameObjectsWithTag("Pieces");
        foreach (GameObject element in pieces)
        {
            element.GetComponent<Box>().enabled = true;
        }
        SceneManager.UnloadSceneAsync(level);

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
