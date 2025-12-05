using UnityEngine;
using TMPro;
public class Mensajitos : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI mensajes;
    public GameObject textImage;

    [SerializeField] LeanTweenType curva;
    public Vector2 newPosition = new Vector2 (0,0);
   
    public float velocidadDeAnimacion = 0;

    public float timer = 0f;
    bool juegoActivo = false;

    

    private Vector3 scaleOriginalPrimerMensaje;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        juegoActivo = true;
        scaleOriginalPrimerMensaje = textImage.transform.localScale;


    }

    // Update is called once per frame
    void Update()
    {
        if (juegoActivo)
        {
            timer += Time.deltaTime;

            if (timer >= 1f && timer < 1f + Time.deltaTime)
            {
                PrimerMensaje(); 
            }

            if (timer >= 5f)
            {
                LeanTween.scale(textImage, Vector3.zero, velocidadDeAnimacion);
                
            }


        }
    }
    public void PrimerMensaje()
    {
        mensajes.text = "Golpea la pelota para destruir los obstaculos";
        textImage.transform.localScale = scaleOriginalPrimerMensaje;
        LeanTween.scale(textImage, newPosition, velocidadDeAnimacion).setEase(curva);
    }
    public void SegundoMensaje()
    {

    }
}
