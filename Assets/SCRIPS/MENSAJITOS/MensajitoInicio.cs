using UnityEngine;

public class MensajitoInicio : MonoBehaviour
{
    public GameObject mensajito;
    public float velocidadDeAnimacion = 0;
    public float newPositionY = 0;
    public float oldPositionY = 0;
    [SerializeField] LeanTweenType curva;

    Vector2 positionOriginalMensajito;

    public float time = 0;
    private bool contadorActivo = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        positionOriginalMensajito = mensajito.transform.localPosition;


        PrimerMensaje();
    }

    // Update is called once per frame
    void Update()
    {
        if (contadorActivo)
        {
            time += Time.deltaTime;
        }


    

        Regresar();
    }
    void PrimerMensaje()
    {
        mensajito.transform.localPosition = positionOriginalMensajito;

        LeanTween.moveLocalY(mensajito, newPositionY, velocidadDeAnimacion).setEase(curva);

       
    }
    void Regresar()
    {

        if (time >= 5f && contadorActivo)
        {
            
            LeanTween.moveLocalY(mensajito, oldPositionY, velocidadDeAnimacion).setEase(curva);
            contadorActivo = false;
            time = 0;
        }
    }
}
