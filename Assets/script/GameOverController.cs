using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  

public class GameOverController : MonoBehaviour
{
    public Button buttonRestart;

    private void Awake()
    {
        
        buttonRestart.onClick.AddListener(ReloadLevel);
    }

    public void PlayerDied()
    {
        gameObject.SetActive(true);
    }

    public void ReloadLevel()
    {
        Debug.Log("Reloading scene 0");
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex); 
    }
}
