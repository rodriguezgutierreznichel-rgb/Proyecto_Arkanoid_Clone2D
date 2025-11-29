using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
public class TextoDerrota : MonoBehaviour
{
    public TextMeshProUGUI tituloDerrota, botonReintentar, botonSalir;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tituloDerrota.text = LocalizationSettings.StringDatabase.GetLocalizedString("DERROTA", "-HAS PERDIDO");
        botonReintentar.text = LocalizationSettings.StringDatabase.GetLocalizedString("DERROTA", "-REINTENTAR");
        botonSalir.text = LocalizationSettings.StringDatabase.GetLocalizedString("DERROTA", "-SALIR");
    }
}
