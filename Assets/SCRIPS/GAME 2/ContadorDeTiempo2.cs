using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ContadorDeTiempo2 : MonoBehaviour
{
    public float time = 60;
    [SerializeField] TextMeshProUGUI tiempo;

    private bool contando = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            contando = true;
        }

        // Si está activo, sumar tiempo cada frame
        if (contando)
        {
            time -= Time.deltaTime;
            tiempo.text = time.ToString("00");
        }

        if (time <= 0)
        {
            SceneManager.LoadScene("UI_VICTORIA 2");
        }
    }



}
