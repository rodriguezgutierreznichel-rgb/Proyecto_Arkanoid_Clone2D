using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
public class TextoInicio : MonoBehaviour
{
    public TextMeshProUGUI tituloDelJuego, botonEmpezar, botonSalir, botonExamen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tituloDelJuego.text = LocalizationSettings.StringDatabase.GetLocalizedString("INICIO", "-Proyecto Arkanoid Clone");
        botonEmpezar.text = LocalizationSettings.StringDatabase.GetLocalizedString("INICIO", "-EMPEZAR");
        botonSalir.text = LocalizationSettings.StringDatabase.GetLocalizedString("INICIO", "-SALIR");
        botonExamen.text = LocalizationSettings.StringDatabase.GetLocalizedString("DERROTA", "-EXAMEN");
    }
}
