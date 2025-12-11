using UnityEngine;

public class PlayerMove2 : MonoBehaviour
{
    
    public static PlayerMove2 instancia;
    public static int daño = 0;

    public Rigidbody2D fisicaPlayer;

    private float posicionPlayer; //Posicion inicial del objeto.

    public float velocidadPlayer = 25; //Velocidad del obejto.

    private Vector2 directionPlayer; //Direccion que se movera el objeto.

    bool juegoNormal = false;
    bool juegoInvertido = false;

    public float tiempoEfectoNegativo = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        juegoInvertido = false;
        juegoNormal = true;
        if (instancia == null)
        {
            instancia = this;

        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (juegoNormal == true && juegoInvertido == false)
        {
            JuegoNormal();
           
        }
        if (juegoNormal == false && juegoInvertido == true)
        {
            JuegoInvertido();
        }
    }

    void JuegoNormal()
    {
        posicionPlayer = Input.GetAxisRaw("Horizontal");

        if (posicionPlayer == 1) //Si presiono > o la D...
        {
            directionPlayer = Vector2.right; //El objeto se mueve a la derecha.
        }
        else if (posicionPlayer == -1) //Si presiono < o la A...
        {
            directionPlayer = Vector2.left; //El objeto se mueve a la izquierda.
        }
        else if (posicionPlayer == 0) //Si el valor de inicio es 0, es decir, si no cambia su dirección...
        {
            directionPlayer = Vector2.zero; //El objeto no se mueve.
        }

        fisicaPlayer.AddForce(directionPlayer * velocidadPlayer * Time.deltaTime * 100); //Ejerce la fuerza para mover el objeto.
    }
    public void RecibirDaño(bool dañoEnviado)
    {
        juegoInvertido = true;
        juegoNormal = false;
        JuegoInvertido();

    }

    void JuegoInvertido()
    {
        
        tiempoEfectoNegativo = tiempoEfectoNegativo + Time.deltaTime;
        Debug.Log("Se cambiaron los controles");
        posicionPlayer = Input.GetAxisRaw("Horizontal");

        if (posicionPlayer == -1) //Si presiono > o la D...
        {
            directionPlayer = Vector2.right; //El objeto se mueve a la derecha.
        }
        else if (posicionPlayer == 1) //Si presiono < o la A...
        {
            directionPlayer = Vector2.left; //El objeto se mueve a la izquierda.
        }
        else if (posicionPlayer == 0) //Si el valor de inicio es 0, es decir, si no cambia su dirección...
        {
            directionPlayer = Vector2.zero; //El objeto no se mueve.
        }

        fisicaPlayer.AddForce(directionPlayer * velocidadPlayer * Time.deltaTime * 100); //Ejerce la fuerza para mover el objeto.

        

        if (tiempoEfectoNegativo >= 5)
        {
            juegoInvertido = false;
            juegoNormal = true;
            tiempoEfectoNegativo = 0;
        }
    }
}
