using UnityEngine;

public class LeftClickAudio : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Check if an AudioSource component exists, if not, add one
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Assign the AudioClip to the AudioSource
        audioSource.clip = audioClip;
    }

    void Update()
    {
        // Check for left mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Check if the audio clip is not null and the AudioSource is not already playing
            if (audioClip != null && !audioSource.isPlaying)
            {
                // Play the audio clip
                audioSource.Play();
            }
        }
    }
}