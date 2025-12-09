using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public static Vidas instancia;
    public static int vidas = 3;
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
        if (instancia != null && instancia != this)
        {
            Destroy(gameObject);
            return;
        }

        instancia = this;

        vidas = 3;
        numeroDeObstaculosDestruidos = 0;
        numeroDeVidas.text = vidas.ToString();
        corazonMedio.SetActive(false);
        corazonNegro.SetActive(false);
    }

    public void PerderVidas(int lives)
    {
        vidas = vidas - lives;
        numeroDeVidas.text = vidas.ToString();

        LeanTween.scale(numeroDeVidas.rectTransform, escalaNumeroDeVidas, velocidadDeAnimacion).setEase(curva).setOnComplete(() =>
        {
            LeanTween.scale(numeroDeVidas.rectTransform, escalaOriginalNumeroDeVidas, velocidadDeAnimacion)
                .setEase(curva);
        });

        if (vidas <= 2)
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

        if (vidas <= 1)
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



        if (vidas <= 0)
        {
            SceneManager.LoadScene("UI_DERROTA");

            numeroDeVidas.gameObject.SetActive(false);
            corazones.SetActive(false);
            corazonMedio.SetActive(false);
            corazonNegro.SetActive(false);


        }

        

    }

    public void PerderVidasOBS(int livesOBS)
    {
        numeroDeObstaculosDestruidos += livesOBS;
        Debug.Log("Obstáculos destruidos = " + numeroDeObstaculosDestruidos);

        if (numeroDeObstaculosDestruidos >= numeroTotalDeVidasDeObstaculos)
        {
            Debug.Log("VICTORIA ACTIVADA");
            SceneManager.LoadScene("UI_VICTORIA");
        }
    }
}
