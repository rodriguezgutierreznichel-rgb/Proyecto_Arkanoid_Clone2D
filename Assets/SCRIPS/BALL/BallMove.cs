using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class BallMove : MonoBehaviour
{
    public TextMeshProUGUI numeroDeVidas;

    public GameObject player, ball, corazones;


    [SerializeField] public LeanTweenType curva;
    public float velocidadDeAnimacion = 0;
    public Vector2 escalaCorazon = new Vector2(0, 0);

    public float time = 0;
    [SerializeField] TextMeshProUGUI tiempo;

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

        

        startPositionBall = ball.transform.position;
        startPositionPlayer = player.transform.position;

        directionPelota.x = Random.Range(-1f, 1f);

        directionPelota.y = 1;

        fisicaPelota.AddForce(directionPelota * velocidadPelota);
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        tiempo.text = time.ToString("00");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("DeadZone"))
        {
            lives--;
            numeroDeVidas.text = lives.ToString();
            LeanTween.scale(corazones, escalaCorazon, velocidadDeAnimacion).setEase(curva).setOnComplete(() =>
            {
                LeanTween.scale(corazones, Vector3.one, velocidadDeAnimacion)
                    .setEase(curva);
            });

           
           
                ball.transform.position = startPositionBall;
                player.transform.position = startPositionPlayer;
            
            if (lives <= 0)
            {
                SceneManager.LoadScene("UI_DERROTA");
                numeroDeVidas.gameObject.SetActive(false);
                corazones.SetActive(false);
            }
        }

        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            Destroy(collision.gameObject);
            
            numeroDeObstaculosDestruidos++;

            if (numeroDeObstaculosDestruidos >= 20)
            {
                SceneManager.LoadScene("UI_VICTORIA");
                numeroDeVidas.gameObject.SetActive(false);
                corazones.SetActive(false);
            }
        }

        
        




    }
}
