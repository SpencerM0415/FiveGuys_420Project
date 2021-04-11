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
        SceneManager.LoadScene(level, LoadSceneMode.Additive);
    }

    public void UnloadScene(int level)
    {
        SceneManager.UnloadScene(level);

    }
}
