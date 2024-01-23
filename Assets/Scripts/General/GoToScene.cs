using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToScene : MonoBehaviour

{

    //Load a scene based on a string name
    [SerializeField] private string _sceneName;

    public void LoadLevel()
    {
  
    }
    public void QuitLevel()
    {
        Application.Quit();



    }



}
