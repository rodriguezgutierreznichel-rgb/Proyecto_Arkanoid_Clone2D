using TMPro;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
   

    public int vidas = 1;
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
                Destroy(gameObject);
            Puntos.instancia.SumarPuntos(100);
        }
    }
}
