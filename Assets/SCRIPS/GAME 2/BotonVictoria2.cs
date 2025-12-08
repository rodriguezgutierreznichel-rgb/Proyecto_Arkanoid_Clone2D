using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonVictoria2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReintentarJuego()
    {
        SceneManager.LoadScene("GAME 2");
    }
    public void SalirDelJuego()
    {
        SceneManager.LoadScene("UI_INICIO 2");
    }
}
