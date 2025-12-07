using UnityEngine;
using UnityEngine.Audio;

public class SonidoVictoria : MonoBehaviour
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
