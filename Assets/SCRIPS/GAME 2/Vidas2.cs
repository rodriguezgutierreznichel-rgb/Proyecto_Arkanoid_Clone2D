using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vidas2 : MonoBehaviour
{
    public static Vidas2 instancia;
    public static int vidas2 = 3;
    public TextMeshProUGUI numeroDeVidas;
    public GameObject corazones, corazonMedio, corazonNegro;

    public float numeroDeObstaculosDestruidos = 0;
    float numeroTotalDeVidasDeObstaculos = 20;

    [SerializeField] public LeanTweenType curva;
    public float velocidadDeAnimacion = 0;
    public Vector2 escalaCorazon = new Vector2(0f, 0f);
    public Vector2 escalaNumeroDeVidas = new Vector2(0f, 0f);
    public Vector2 escalaOriginalNumeroDeVidas = new Vector2(2.5f, 2.5f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;

        }
        vidas2 = 3;
        numeroDeVidas.text = vidas2.ToString();
        corazonMedio.SetActive(false);
        corazonNegro.SetActive(false);
    }

    public void PerderVidas(int lives)
    {
        vidas2 = vidas2 - lives;
        numeroDeVidas.text = vidas2.ToString();

        LeanTween.scale(numeroDeVidas.rectTransform, escalaNumeroDeVidas, velocidadDeAnimacion).setEase(curva).setOnComplete(() =>
        {
            LeanTween.scale(numeroDeVidas.rectTransform, escalaOriginalNumeroDeVidas, velocidadDeAnimacion)
                .setEase(curva);
        });

        if (vidas2 <= 2)
        {
            corazones.SetActive(false);
            corazonMedio.SetActive(true);
            Instantiate(corazonMedio, transform.position, Quaternion.identity);
            LeanTween.scale(corazonMedio, escalaCorazon, velocidadDeAnimacion).setEase(curva).setOnComplete(() =>
            {
                LeanTween.scale(corazonMedio, Vector3.one, velocidadDeAnimacion)
                    .setEase(curva);
            });
        }

        if (vidas2 <= 1)
        {
            corazonMedio.SetActive(false);
            corazonNegro.SetActive(true);
            Instantiate(corazonNegro, transform.position, Quaternion.identity);
            LeanTween.scale(corazonNegro, escalaCorazon, velocidadDeAnimacion).setEase(curva).setOnComplete(() =>
            {
                LeanTween.scale(corazonNegro, Vector3.one, velocidadDeAnimacion)
                    .setEase(curva);
            });
        }



        if (vidas2 <= 0)
        {
            SceneManager.LoadScene("UI_DERROTA 2");

            numeroDeVidas.gameObject.SetActive(false);
            corazones.SetActive(false);
            corazonMedio.SetActive(false);
            corazonNegro.SetActive(false);


        }



    }

   
}
