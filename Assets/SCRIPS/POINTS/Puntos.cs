using UnityEngine;
using TMPro;
public class Puntos : MonoBehaviour
{
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static Puntos instancia; // Referencia global
    public static int points = 0;   // Variable global
    public TextMeshProUGUI numeroDePuntos;

    void Awake()
    {
        instancia = this;
        points = 0; // Reiniciamos los puntos cada vez que se carga la escena
        numeroDePuntos.text = points.ToString();
    }

    public void SumarPuntos(int p)
    {
        points += p;
        numeroDePuntos.text = points.ToString();
    }
}
