using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance; // Singleton para acceso global

    [Header("Contador de Obstáculos")]
    public int obstaculosDestruidos = 0;
    public int obstaculosParaVictoria = 20;

    private void Awake()
    {
        // Singleton simple
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Llamar desde cada obstáculo cuando se destruya
    public void ObstaculoDestruido()
    {
        obstaculosDestruidos++;
        Debug.Log("Obstáculos destruidos: " + obstaculosDestruidos);

        if (obstaculosDestruidos >= obstaculosParaVictoria)
        {
            Debug.Log("¡Victoria! Cambiando de escena...");
            SceneManager.LoadScene("UI_VICTORIA");
        }
    }






}
