using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private Estados estadoActual;


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
}
