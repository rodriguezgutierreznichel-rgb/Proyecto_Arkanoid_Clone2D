using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D fisicaPlayer;

    private float posicionPlayer; //Posicion inicial del objeto.

    public float velocidadPlayer = 25; //Velocidad del obejto.

    private Vector2 directionPlayer; //Direccion que se movera el objeto.

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
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
    
}
