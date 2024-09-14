
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyController : MonoBehaviour
{   
    public Button buttonplay;
    public GameObject LevelSelection; 

    

    private void Awake()
    {
        buttonplay.onClick.AddListener(PlayGame);
    }
    private void PlayGame()
    {
      

      SoundManager.Instance.Play(Sounds.ButtonClick);  
      LevelSelection.SetActive(true); 

            
    }



 
    
=======
      LevelSelection.SetActive(true); 
            
    }


 
    
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene"); 
    }

    public void QuitGame()
    {
        Debug.Log("Quit the game");
        Application.Quit();
    }


}
