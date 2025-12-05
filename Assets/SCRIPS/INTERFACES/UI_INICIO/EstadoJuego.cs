using UnityEngine;

public class EstadoJuego : Estados
{
    public void Entrar(StateMachine interfaces)
    {
        interfaces.ui_Game.SetActive(true);
    }

    public void Ejecutar(StateMachine interfaces)
    {
       
    }

    public void Salir(StateMachine interfaces)
    {
       interfaces.ui_Game.SetActive(false);
    }
}
