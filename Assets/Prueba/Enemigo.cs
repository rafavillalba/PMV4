using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float Velocidad_horizontal = 2f;
    public float Tiempo_Vida = 5f;

    void Start()
    {
        Invoke("Destruir", Tiempo_Vida);
    }

    void Destruir()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Translate(Vector2.down * Velocidad_horizontal * Time.deltaTime);
    }
}
