<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToScene : MonoBehaviour
{
    //Load a scene based on a string name
    [SerializeField] private string _sceneName;

    public void LoadLevel()
    {
        LevelManager.Instance.LoadLevel(_sceneName);
    }

    public void QuitLevel()
    {
        Application.Quit();

        AudioManager.Instance.PlaySound("Test");
    }
}
=======
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
>>>>>>> c3828b24bd331a1ca2e936bb41e92fda731e28e4
