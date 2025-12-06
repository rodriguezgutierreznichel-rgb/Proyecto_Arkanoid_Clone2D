using UnityEngine;
using UnityEngine.Audio;

public class SonidoInicial : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip sonidoDeAmbiente;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        audioSource.playOnAwake = false; // Evita que el sonido se reproduzca automáticamente al iniciar.
    }

    // Update is called once per frame
    void Update()
    {
        SonidoDeAmbiente();
    }
    void SonidoDeAmbiente()
    {
        audioSource.PlayOneShot(sonidoDeAmbiente); // Reproduce el sonido de click
    }
}
