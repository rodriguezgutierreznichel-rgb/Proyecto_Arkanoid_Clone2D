using TMPro;
using UnityEngine;

public class ObstaculosAlgoDuro : MonoBehaviour
{
    

    public int vidas = 1;
    public int puntos = 300;
    private int vidaPerdida = 1;

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
                Puntos.instancia.SumarPuntos(puntos);
                Vidas.instancia.PerderVidasOBS(vidaPerdida);
                Destroy(gameObject);
            }

        }
    }
}
