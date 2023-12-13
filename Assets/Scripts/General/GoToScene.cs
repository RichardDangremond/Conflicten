using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GoToScene : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string _sceneName;

    private bool isTransitioning = false; // Add a variable to track the transitioning state

    public void LoadLevel()
    {
        if (!isTransitioning)
        {
            isTransitioning = true; // Mark the transition as active to prevent it from being started again

            if (animator != null)
            {
                animator.SetTrigger("FadeOut");
            }

            // Call the transition method after the animation is completed (this requires some setup in the Animator)
            StartCoroutine(LoadLevelAfterAnimation());
        }
    }

    IEnumerator LoadLevelAfterAnimation()
    {
        yield return new WaitForSeconds(/* Duration of the fade-out animation */);

        LevelManager.Instance.LoadLevel(_sceneName);

        // Reset the transitioning state
        isTransitioning = false;
    }

    public void QuitLevel()
    {
        Application.Quit();
    }
}

