using UnityEngine;
using UnityEngine.Audio;

public class SonidoGame : MonoBehaviour
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
