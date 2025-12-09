using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class Texto : MonoBehaviour
{
    public TextMeshProUGUI mensajito;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mensajito.text = LocalizationSettings.StringDatabase.GetLocalizedString("MENSAJITOS", "-Pulsa el boton \"ESPACIO\" para empezar. Muevete y destruye todos los obstaculos. Y no permitas que la bola caiga a la DEAP ZONE");
    }
}
