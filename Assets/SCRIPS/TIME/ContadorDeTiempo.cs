using TMPro;
using UnityEngine;
public class ContadorDeTiempo : MonoBehaviour
{
    public float time = 0;
    [SerializeField] TextMeshProUGUI tiempo;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        tiempo.text = time.ToString("00");
    }
    

}
