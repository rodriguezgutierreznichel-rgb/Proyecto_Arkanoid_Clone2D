using UnityEngine;

public class EstadoVictoria : Estados
{
    public void Entrar(StateMachine interfaces)
    {
        interfaces.ui_Victoria.SetActive(true);
    }

    public void Ejecutar(StateMachine interfaces)
    {

    }

    public void Salir(StateMachine interfaces)
    {
        interfaces.ui_Victoria.SetActive(false);
    }
}
