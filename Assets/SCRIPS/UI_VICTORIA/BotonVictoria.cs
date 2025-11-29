using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonVictoria : MonoBehaviour
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
        SceneManager.LoadScene("GAME");
    }
    public void SalirDelJuego()
    {
        SceneManager.LoadScene("UI_INICIO");
    }
}
