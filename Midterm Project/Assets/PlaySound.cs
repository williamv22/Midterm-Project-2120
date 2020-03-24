using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=cXiVKPfNK1U
//Used This video to work on the sound

public class PlaySound : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool AudioGotPlayed;
    // Start is called before the first frame update
    void Start() 
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        if (!AudioGotPlayed)
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            AudioGotPlayed = true;
        }
    }
}
