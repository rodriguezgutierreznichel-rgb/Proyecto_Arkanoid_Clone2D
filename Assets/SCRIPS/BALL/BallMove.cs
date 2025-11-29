using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMove : MonoBehaviour
{
    public GameObject player, ball;

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

            if (lives <= 2)
            {
                ball.transform.position = startPositionBall;
                player.transform.position = startPositionPlayer;
            }
            if (lives <= 0)
            {
                SceneManager.LoadScene("UI_DERROTA");
            }
        }

        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            Destroy(collision.gameObject);
            
            numeroDeObstaculosDestruidos++;

            if (numeroDeObstaculosDestruidos >= 20)
            {
                SceneManager.LoadScene("UI_VICTORIA");
            }
        }

        
        




    }
}
