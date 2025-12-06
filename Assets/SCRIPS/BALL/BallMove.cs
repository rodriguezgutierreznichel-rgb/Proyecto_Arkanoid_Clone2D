using TMPro;
using UnityEditor.Localization.Plugins.XLIFF.V20;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BallMove : MonoBehaviour
{
    public StateMachine stateMachine;

    public TextMeshProUGUI numeroDeVidas;

    public GameObject player, ball, corazones, corazonMedio, corazonNegro;
    

    public float vidasOBS = 1;

    public float puntuacion = 0;
    [SerializeField] TextMeshProUGUI numeroDePuntos;


    [SerializeField] public LeanTweenType curva;
    public float velocidadDeAnimacion = 0;
    public Vector2 escalaCorazon = new Vector2(0, 0);
    public Vector2 escalaNumeroDeVidas = new Vector2(2.5f, 2.5f);
    public Vector2 escalaOriginalNumeroDeVidas = new Vector2(3, 3);



    public Rigidbody2D fisicaPelota;

    public float velocidadPelota = 800;

    private Vector2 directionPelota;

    public float lives = 3;
    public float livesObs = 4;
   
    public float numeroDeObstaculosDestruidos = 0;
    Vector2 startPositionBall;
    Vector2 startPositionPlayer;

   

    void Start()
    {
        numeroDeVidas.text = lives.ToString();
        numeroDePuntos.text = puntuacion.ToString();

        corazonMedio.SetActive(false);
        corazonNegro.SetActive(false);
        

        startPositionBall = ball.transform.position;
        startPositionPlayer = player.transform.position;

       
        

        directionPelota.x = Random.Range(-1f, 1f);

        directionPelota.y = 1;

        fisicaPelota.AddForce(directionPelota * velocidadPelota);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("DeadZone"))
        {
            lives--;
            ball.transform.position = startPositionBall;
            player.transform.position = startPositionPlayer;
            numeroDeVidas.text = lives.ToString();

            LeanTween.scale(numeroDeVidas.rectTransform, escalaNumeroDeVidas, velocidadDeAnimacion).setEase(curva).setOnComplete(() =>
            {
                LeanTween.scale(numeroDeVidas.rectTransform, escalaOriginalNumeroDeVidas, velocidadDeAnimacion)
                    .setEase(curva);
            });

            if (lives <= 2)
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

            if (lives <= 1)
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

            
            
            if (lives <= 0)
            {
                SceneManager.LoadScene("UI_DERROTA");

                numeroDeVidas.gameObject.SetActive(false);
                corazones.SetActive(false);
                corazonMedio.SetActive(false);
                corazonNegro.SetActive(false);

                
            }
        }

        if (collision.gameObject.CompareTag("Obstaculo"))
        {
           

           
            vidasOBS--;
            numeroDeObstaculosDestruidos++;

            if (numeroDeObstaculosDestruidos >= 35)
            {

                SceneManager.LoadScene("UI_VICTORIA");

                numeroDeVidas.gameObject.SetActive(false);
                corazones.SetActive(false);
                corazonMedio.SetActive(false);
                corazonNegro.SetActive(false);
               
            }
           
        }
       
    }


}
