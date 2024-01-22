using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject Enemigo;

    public float tiempospawnmin;
    public float tiempospawnmax;
    private float tiempoproxspawn;

    public Vector2 areamin; //esquina inf izquierda
    public Vector2 areamax; //esquina sup derecha

    void Start()
    {
        tiempoproxspawn = UnityEngine.Random.Range(tiempospawnmin,tiempospawnmax);
    }

    void Update()
    {
        if (Time.time > tiempoproxspawn)
        {
            SpawnEnemigo();
            tiempoproxspawn = Time.time + UnityEngine.Random.Range(tiempospawnmin, tiempospawnmax);
        }   
    }

    void SpawnEnemigo()
    {
        float posicionX = UnityEngine.Random.Range(areamin.x, areamax.x);
        float posicionY = UnityEngine.Random.Range(areamin.y, areamax.y);

        Vector2 posicionSpawn = new Vector2(posicionX, posicionY);

        GameObject enemigo = Instantiate(Enemigo, posicionSpawn, Quaternion.identity);
    }
}
