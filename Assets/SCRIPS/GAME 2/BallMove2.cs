using TMPro;
using UnityEditor.Localization.Plugins.XLIFF.V20;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BallMove2 : MonoBehaviour
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

    bool activo = false;
    void Start()
    {
       
        startPositionBall = ball.transform.position;
        startPositionPlayer = player.transform.position;

        directionPelota.x = 0;

        directionPelota.y = 0;

        fisicaPelota.AddForce(directionPelota * velocidadPelota);

    }

    // Update is called once per frame
    void Update()
    {
        // Solo ejecuta Empezar si espacio es presionado y la bola NO está activa
        if (Input.GetKeyDown(KeyCode.Space) && !activo)
        {
            Empezar();
            activo = true; // Esto evita que se vuelva a ejecutar
        }
    }

    void Empezar()
    {
        directionPelota.x = Random.Range(-1f, 1f);

        directionPelota.y = 1;

        fisicaPelota.AddForce(directionPelota * velocidadPelota);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("DeadZone"))
        {

            Vidas2.instancia.PerderVidas(1);
            
            ball.transform.position = startPositionBall;
            player.transform.position = startPositionPlayer;

        }

        
       
    }


}
