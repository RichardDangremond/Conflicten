// Import necessary Unity and VideoPlayer libraries
using UnityEngine;
using UnityEngine.Video;

// Define a class named VideoTrigger that inherits from MonoBehaviour
public class VideoTrigger : MonoBehaviour

{
    // SerializeField allows private variables to be visible in the Unity Editor
    // Define a private variable to reference the attachment point for the film hook
    [SerializeField]
    private GameObject FilmHaakAttachpoint;

    // Define a private variable to reference the GameObject representing the film roll
    [SerializeField]
    private GameObject filmrolVol;

    // Define a private variable to reference the VideoPlayer component for video playback
    [SerializeField]
    private VideoPlayer videoPlayer;

    // A boolean flag to track whether the video has been played
    private bool hasPlayed = false;

    // OnTriggerEnter is called when another collider enters the trigger collider of this GameObject
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log
        // Check if the GameObject representing the film roll is in contact with the film hook attachment point
        if (other.gameObject.CompareTag("filmrol") && !hasPlayed)
        {
            
            // If the film roll GameObject is in contact and the video hasn't been played yet
            // Check if the attachment point for the film hook matches the entered GameObject
         
            {
                // If the film hook attachment point matches, play the video
                PlayVideo();
                // Set the flag to true to indicate that the video has been played
                hasPlayed = true;
            }
        }
    }

    // Method to handle video playback
    private void PlayVideo()
    {
        // Check if the VideoPlayer component is assigned
        if (videoPlayer != null)
        {
            // Add an event handler for when the video reaches its end
            videoPlayer.loopPointReached += OnVideoEnd;

            // Start playing the video
            videoPlayer.Play();
        }
    }

    // Event handler for when the video reaches its end
    private void OnVideoEnd(VideoPlayer vp)
    {
        // The video has ended, destroy the VideoPlayer component
        Destroy(vp);

      
    }
}