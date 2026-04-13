using UnityEngine;

public class IceCream : MonoBehaviour
{
    public AudioSource audioSource;

    void OnMouseDown()
    {
        audioSource.Play();
    }
}

