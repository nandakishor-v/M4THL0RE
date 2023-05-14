using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitPortal : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 1f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.layer == 8)
        {
            StartCoroutine(WaitAndLoadLevel());
        }
    }

    private IEnumerator WaitAndLoadLevel()
    {
        yield return new WaitForSecondsRealtime(levelLoadDelay);
        var currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = ++currentScene;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
}
