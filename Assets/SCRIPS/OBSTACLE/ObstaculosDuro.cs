using TMPro;
using UnityEngine;

public class ObstaculosDuro : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI numeroDePuntos;
    public int points = 0;
    public int puntos = 200;

    public int vidas = 4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pelota"))
        {
            vidas--;

            if (vidas == 0)
            {
                Destroy(gameObject);
                Puntos.instancia.SumarPuntos(puntos); // Referencia segura y sin deprecated
            }
        }
    }
}
