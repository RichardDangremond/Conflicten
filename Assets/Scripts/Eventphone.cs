using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventphone : MonoBehaviour


{
    [SerializeField] private int firstConversationTime = 5;
    [SerializeField] private int secondConversationTime = 5;
    [SerializeField] private AudioSource callSound;
    [SerializeField] private AudioSource firstConversation;
    [SerializeField] private AudioSource secondConversation;


    private bool pickedUpFirstCall = false;
    private bool pickedUpSecondCall = false;


    void Start()
    {
        // Start Call sound in firstConversationTime seconds
        StartCoroutine(CallSoundCoroutine(firstConversationTime));
    }

    // Start call sound after the duration has reached firstConversationTime
    private IEnumerator CallSoundCoroutine(int waitDuration)
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(waitDuration);

        PlayCallSound();
    }

    private void PlayCallSound()
    {
        Debug.Log("afspelen");
        callSound.Play();
    }

    // Called when the player answers  the phone
    
    public void OntOnPlayerAnswer()

    {
            // The call sound must be playing when the player picked up the phone
            if (callSound.isPlaying)
        {
            // Stop the calling sound
            callSound.Stop();

            // If the first pick up call sound has NOT played before
            if (!pickedUpFirstCall)
            {
                // Play first convo
                firstConversation.Play();

                // Mark first call as answered
                pickedUpFirstCall = true;

                // Start Call sound in secondConversationTime seconds
                StartCoroutine(CallSoundCoroutine(secondConversationTime));
                return;
            }

            // The player has answered the first Call, but not the seccond
            if (pickedUpFirstCall && !pickedUpSecondCall)
            {
                secondConversation.Play();
                pickedUpSecondCall = true;
            }
        }
    }
}