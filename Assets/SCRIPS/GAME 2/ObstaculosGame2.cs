using TMPro;
using UnityEngine;

public class ObstaculosGame2 : MonoBehaviour
{
    [SerializeField]
    LeanTweenType curva;

    public GameObject obstaculo;
    public float velocidadDeAnimacion = 0f;
    public Vector3 newScale = new Vector3(0f, 0f, 0f);
   


    public int vidas = 1;
    private int vidaPerdida = 1;
    public int puntos = 100;

    
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
            LeanTween.scale(obstaculo, newScale, velocidadDeAnimacion)
               .setEase(curva)
               .setOnComplete(() =>
               {
                   gameObject.SetActive(false);
               });



            Puntos2.instancia.SumarPuntos(puntos);
            
            

        }
    }
}
