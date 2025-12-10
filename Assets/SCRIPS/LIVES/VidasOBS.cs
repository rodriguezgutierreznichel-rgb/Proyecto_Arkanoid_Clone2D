using UnityEngine;
using UnityEngine.SceneManagement;

public class VidasOBS : MonoBehaviour
{
    public static VidasOBS instancia;
    


    public float numeroDeObstaculosDestruidos = 0;
    float numeroTotalDeVidasDeObstaculos = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instancia != null && instancia != this)
        {
            Destroy(gameObject);
            return;
        }

        instancia = this;

        
        numeroDeObstaculosDestruidos = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerderVidasOBS(int livesOBS)
    {
        numeroDeObstaculosDestruidos += livesOBS;
        Debug.Log("Obstáculos destruidos = " + numeroDeObstaculosDestruidos);

        if (numeroDeObstaculosDestruidos == numeroTotalDeVidasDeObstaculos)
        {
            Debug.Log("VICTORIA ACTIVADA");
            SceneManager.LoadScene("UI_VICTORIA");
        }
    }
}
