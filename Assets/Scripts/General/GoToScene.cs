using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
    
{

    [SerializeField] private Animator animator;


    //Load a scene based on a string name
    [SerializeField] private string _sceneName;

    public void LoadLevel()
    {
        LevelManager.Instance.LoadLevel(_sceneName);
        animator.SetTrigger("FadeOut");

    }
     public void QuitLevel()
    {
        Application.Quit();
     
    }



}

