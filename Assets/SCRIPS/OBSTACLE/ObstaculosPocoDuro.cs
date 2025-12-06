using TMPro;
using UnityEngine;

public class ObstaculosPocoDuro : MonoBehaviour
{
   


    public int vidas = 2;

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
                Puntos.instancia.SumarPuntos(200);
            }
        }
    }
}
