using UnityEngine;
using TMPro;
public class AnimationGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI contador, numeroDeVidas;

    public GameObject corazon;

    [SerializeField] LeanTweenType curva;

    public float velocidadDeAnimacion = 0f;

    public Vector2 newPositionContador = new Vector2(0, 0);
    public Vector2 newPositionNumeroDeVidas = new Vector2(0, 0);
    public Vector2 newPositionCorazon = new Vector2(0, 0);

    Vector2 escalaOriginalDelContador;
    Vector2 escalaOriginalDelNumeroDeVidas;
    Vector2 escalaOriginalDelCorazon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        escalaOriginalDelContador = contador.transform.localScale;
        escalaOriginalDelNumeroDeVidas = numeroDeVidas.transform.localScale;
        escalaOriginalDelCorazon = corazon.transform.localScale;

        Animacion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Animacion()
    {
        contador.transform.localScale = escalaOriginalDelContador;
        numeroDeVidas.transform.localScale = escalaOriginalDelNumeroDeVidas;
        corazon.transform.localScale = escalaOriginalDelCorazon;

        LeanTween.scale(contador.rectTransform, newPositionContador, velocidadDeAnimacion).setEase(curva);
        LeanTween.scale(numeroDeVidas.rectTransform, newPositionNumeroDeVidas, velocidadDeAnimacion).setEase(curva);
        LeanTween.scale(corazon, newPositionCorazon, velocidadDeAnimacion).setEase(curva);
    }
}
