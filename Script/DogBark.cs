using UnityEngine;

public class DogBark : MonoBehaviour
{
    public AudioSource audioSource;

    void OnMouseDown()
    {
        audioSource.Play();
    }
}
