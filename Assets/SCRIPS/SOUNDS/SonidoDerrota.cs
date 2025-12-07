using UnityEngine;
using UnityEngine.Audio;

public class SonidoDerrota : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sonidoDeAmbiente;
    
    void Update()
    {
        SonidoDeAmbiente();
    }
    void SonidoDeAmbiente()
    {
        audioSource.PlayOneShot(sonidoDeAmbiente); 
    }
    
}
