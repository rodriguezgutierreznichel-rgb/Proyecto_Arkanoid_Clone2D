using TMPro;
using UnityEngine;

public class ObstaculosDuro : MonoBehaviour
{
    [SerializeField]
    LeanTweenType curva;

    public GameObject obstaculo;
    public float velocidadDeAnimacion = 0f;
    public Vector3 newScale = new Vector3(0f, 0f, 0f);
    public Vector3 originalScale = new Vector3(2f, 0.5f, 0f);

    public int vidas = 1;
    public int puntos = 400;
    private int vidaPerdida = 1;

    Vector3 escalaOriginal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        escalaOriginal = obstaculo.transform.localScale;
        obstaculo.transform.localScale = escalaOriginal;

        LeanTween.scale(obstaculo, originalScale, velocidadDeAnimacion).setEase(curva);
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
                LeanTween.scale(obstaculo, newScale, velocidadDeAnimacion)
           .setEase(curva)
           .setOnComplete(() =>
           {
               Destroy(obstaculo);
           });

                Puntos.instancia.SumarPuntos(puntos);
                VidasOBS.instancia.PerderVidasOBS(vidaPerdida);
                
            }

        }
    }
}
