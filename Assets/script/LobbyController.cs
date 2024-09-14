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



 
    
}
