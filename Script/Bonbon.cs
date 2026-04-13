using UnityEngine;

public class Bonbon : MonoBehaviour
{
    public AudioSource audioSource;

    void OnMouseDown()
    {
        audioSource.Play();
    }
}

