using UnityEngine;
using TMPro;
public class AnimationDerrota : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI tituloPerder;

    public GameObject botonReintentar, botonSalir;

    [SerializeField] LeanTweenType curva;

    public float velocidadDeAnimacion = 0f;

    public Vector2 newPositionText = new Vector2(0, 0);
    public Vector2 newPositionButton = new Vector2(0, 0);

    Vector2 escalaOriginalDelTitulo;
    Vector2 escalaOriginalDelBotonReintentar;
    Vector2 escalaOriginalDelBotonSalir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        escalaOriginalDelTitulo = tituloPerder.rectTransform.localScale;
        escalaOriginalDelBotonReintentar = botonReintentar.transform.localScale;
        escalaOriginalDelBotonSalir = botonSalir.transform.localScale;

        Animacion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Animacion()
    {
        tituloPerder.rectTransform.localScale = escalaOriginalDelTitulo;
        botonReintentar.transform.localScale = escalaOriginalDelBotonReintentar;
        botonSalir.transform.localScale = escalaOriginalDelBotonSalir;

        LeanTween.scale(tituloPerder.rectTransform, newPositionText, velocidadDeAnimacion).setEase(curva);
        LeanTween.scale(botonReintentar, newPositionButton, velocidadDeAnimacion).setEase(curva);
        LeanTween.scale(botonSalir, newPositionButton, velocidadDeAnimacion).setEase(curva);
    }
}
