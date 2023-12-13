
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger_script : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private int levelToLoad = 0;

    // Add a variable to track whether fading is in progress
    private bool isFading = false;

    void Update()
    {
        // Example: check for a condition to activate FadeToLevel
        if (Input.GetKeyDown(KeyCode.Space) && !isFading)
        {
            FadeToLevel();
        }
    }

    // Trigger the animation
    private void FadeToLevel()
    {
        // Set the trigger to start the "FadeOut" animation
        animator.SetTrigger("FadeOut");

        // Set the flag to indicate that fading is in progress
        isFading = true;
    }

    // Connected to an animation event
    public void OnfadeComplete()
    {
        // Load the level when the fade-out animation is complete
        SceneManager.LoadScene(levelToLoad);
    }
}