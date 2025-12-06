using UnityEngine;

public class EstadoDerrota : Estados
{
    public void Entrar(StateMachine interfaces)
    {
        interfaces.ui_Derrota.SetActive(true);
    }

    public void Ejecutar(StateMachine interfaces)
    {

    }

    public void Salir(StateMachine interfaces)
    {
        interfaces.ui_Derrota.SetActive(false);
    }
}
