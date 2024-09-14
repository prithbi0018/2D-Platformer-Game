using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LevelLoader : MonoBehaviour
{

    private Button button;
    public string LevelName;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        LevelStatus LevelStatus = LevelManager . Instance.GetLevelStatus(LevelName);
        switch(LevelStatus)
        {
            case LevelStatus.Locked:
                Debug.Log("Cant play this level till unloack this");
                break  ;
                
            case LevelStatus.Unlocked:
                SoundManager.Instance.Play(Sounds.ButtonClick);
                SceneManager.LoadScene(LevelName);
                break ;
            case LevelStatus.Completed:
                SoundManager .Instance.Play(Sounds.ButtonClick);
                SceneManager.LoadScene(LevelName);
                break ;

        }

       SceneManager.LoadScene(LevelName);
    }
}