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

    // Define a private variable to reference the VideoPlayer component for video playback
    [SerializeField]
    private VideoPlayer videoPlayer;

    private VideoClip _clip;

    // OnTriggerEnter is called when another collider enters the trigger collider of this GameObject
    private void OnTriggerEnter(Collider other)
    {
        // Check if the GameObject representing the film roll is in contact with the film hook attachment point
        if (other.gameObject.CompareTag("filmrol"))
        {
            
       
         
            
                var filmRol = other.GetComponent<Filmrol>();
                _clip = filmRol.clip;
                if(!filmRol.hasPlayed)
                {
                    PlayVideo();
                    filmRol.hasPlayed = true;
                }
        }
    }

    // Method to handle video playback
    private void PlayVideo()
   
    {
        Debug.Log("Playing video");
        // Check if the VideoPlayer component is assigned
        if (videoPlayer != null)
        {
            videoPlayer.clip = _clip;
            videoPlayer.Prepare();
            videoPlayer.Stop(); // Stop the video if it's playing
            videoPlayer.time = 0f; // Set the playback time to zero
            videoPlayer.Play(); // Play the video

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