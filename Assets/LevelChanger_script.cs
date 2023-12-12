
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelChanger_script : MonoBehaviour
{

    [SerializeField] private Animator animator;


    //level load script with fade in and out animation
    [SerializeField] private int levelToLoad = 0;

    // Update is called once per frame
    void Update()
    {
      // put  if statement here (condition to activate FadeToLevel)
        {
            FadeToLevel();
        }
    }
    // trigger animation 
    [SerializeField] private void FadeToLevel()
    {
        animator.SetTrigger("FadeOut");
    }

    public void OnfadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
