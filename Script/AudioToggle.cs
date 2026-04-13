using UnityEngine;

public class AudioToggle : MonoBehaviour

{
    public AudioSource audioSource;


    void OnMouseDown()
    {
        Debug.Log("CLICK DETECTÉ");
        ToggleAudio();
    }

    public void ToggleAudio()
    {
        if(audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.Play();
        }




    }


}
