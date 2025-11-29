using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
public class TextoVictoria : MonoBehaviour
{
    public TextMeshProUGUI tituloDeVictoria, botonReintentar, botonSalir;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tituloDeVictoria.text = LocalizationSettings.StringDatabase.GetLocalizedString("VICTORIA", "-HAS GANADO");
        botonReintentar.text = LocalizationSettings.StringDatabase.GetLocalizedString("VICTORIA", "-REINTENTAR");
        botonSalir.text = LocalizationSettings.StringDatabase.GetLocalizedString("VICTORIA", "-SALIR");
    }
}
