using UnityEngine;

public interface Estados 
{
    void Entrar(StateMachine interfaces);
    void Ejecutar(StateMachine interfaces);
    void Salir(StateMachine interfaces);
}
