using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] obstaculos;
    public GameObject[] posiciones;

    public float tiempoDePartida = 10f;
    public float tiempo = 5;
    public float timer = 0;

    float nextNPC = 0.0f;
    float minTime = 5f;
    float maxTime = 10f;

    float tiempoObstacle = 0;

    bool isPlaying = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EmpezarJuego();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            tiempoObstacle -= Time.deltaTime;

            if (tiempoObstacle <= 0f)
            {
                DesactivarObstaculos(obstaculos);
                DesactivarObstaculos(posiciones);
            }

            timer = timer + Time.deltaTime;
            nextNPC = nextNPC - Time.deltaTime;

            if (nextNPC < 0.0f)
            {
                GenerarNPC();
            }

            if (timer <= 0.0f)
            {
                isPlaying = false;
            }
        }
    }

    public void EmpezarJuego()
    {
        DesactivarObstaculos(obstaculos);
        DesactivarObstaculos(posiciones);

        nextNPC = Random.Range(minTime,maxTime);
        isPlaying = true;

        timer = tiempoDePartida;
        GenerarTimerNPC();
    }

    void DesactivarObstaculos(GameObject[] prefabs)
    {
        for (int i = 0; i < prefabs.Length; i++)
        {
            prefabs[i].SetActive(false);
        }
    }

    void GenerarNPC()
    {
        DesactivarObstaculos(obstaculos);
        DesactivarObstaculos(posiciones);

        GameObject personajes = SeleccionarPrefabs(obstaculos);

        GameObject spawn = SeleccionarPrefabs(posiciones);

        personajes.SetActive(true);
        spawn.SetActive(true);

        tiempoObstacle = tiempo;

        GenerarTimerNPC();
    }

    GameObject SeleccionarPrefabs(GameObject[] prefabs)
    {
        GameObject prefabAleatorio = prefabs[Random.Range(0, prefabs.Length)];

        if (prefabAleatorio.activeSelf == true)
        {
            while (prefabAleatorio.activeSelf)
            {
                prefabAleatorio = prefabs[Random.Range(0, prefabs.Length)];
            }
        }

        return prefabAleatorio;
    }
    public void GenerarTimerNPC()
    {
        nextNPC = Random.Range(minTime, maxTime);
    }
}
