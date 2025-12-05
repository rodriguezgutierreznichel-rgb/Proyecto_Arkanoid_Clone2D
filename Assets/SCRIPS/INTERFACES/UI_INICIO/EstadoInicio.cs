using UnityEngine;

public class EstadoInicio : Estados
{
    public void Entrar(StateMachine interfaces)
    {
        interfaces.ui_Inicio.SetActive(true);
    }

    public void Ejecutar(StateMachine interfaces)
    {

    }

    public void Salir(StateMachine interfaces)
    {
        interfaces.ui_Inicio.SetActive(false);
    }
}
