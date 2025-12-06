using TMPro;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private Estados estadoActual;

    public BallMove gameManagerScript;





    public GameObject ui_Inicio, ui_Victoria, ui_Derrota, ui_Game;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Inicio();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (estadoActual != null)
        {
            estadoActual.Ejecutar(this);
        }
    }

    public void CambiarEstado(Estados nuevoEstado)
    {
        
        if (estadoActual != null)
        {
            estadoActual.Salir(this);
        }

        estadoActual = nuevoEstado; 
        estadoActual.Entrar(this);  
    }
    public void Inicio()
    {
        CambiarEstado(new EstadoInicio());
    }

    public void IniciarJuego()
    {
        CambiarEstado(new EstadoJuego());
    }

    public void GanarPartida()
    {
        CambiarEstado(new EstadoVictoria());
    }

    public void PerderPartida()
    {
        CambiarEstado(new EstadoDerrota());
    }

    public void Reintentar()
    {
        
    }
}
