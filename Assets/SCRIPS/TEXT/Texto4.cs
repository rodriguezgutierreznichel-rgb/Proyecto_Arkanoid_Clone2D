using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class Texto4 : MonoBehaviour
{
    public TextMeshProUGUI mensajito;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mensajito.text = LocalizationSettings.StringDatabase.GetLocalizedString("MENSAJITOS", "—¿Has perdido? Vaya, qué mal. Pero hey, siempre puedes volver a intentarlo.");
    }
}
