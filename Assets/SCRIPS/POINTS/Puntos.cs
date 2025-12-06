using UnityEngine;
using TMPro;
public class Puntos : MonoBehaviour
{
    public static Puntos instancia;
    public static int points = 0;
    public TextMeshProUGUI numeroDePuntos;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            
        }
            points = 0; 
            numeroDePuntos.text = points.ToString();
    }

    public void SumarPuntos(int puntos)
    {
        points = points + puntos;
        numeroDePuntos.text = points.ToString();
    }
}
