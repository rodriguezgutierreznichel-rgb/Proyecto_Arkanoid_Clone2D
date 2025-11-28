using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody2D fisicaPelota;

    public float velocidadPelota = 800;

    public float lives = 2;

    private Vector2 directionPelota;



    void Start()
    {
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
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Obstaculo duro"))
        {
            lives--;
            if (lives == 0)
            {
                Destroy(collision.gameObject);
                lives = 2;
            }
        }
    }
}
