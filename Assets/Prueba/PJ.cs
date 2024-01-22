using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public GameObject balaPrefab;
    public Transform puntoDisparo;
    public float velocidadDisparo = 10f;

    void Update()
    {
        Movimiento();
        DisparoBala();
    }

    void Movimiento()
    {
        // Control del movimiento horizontal (de izquierda a derecha)
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(movimientoHorizontal, 0f) * Time.deltaTime * velocidadMovimiento);

        // Limitar el movimiento para que el personaje no salga de la pantalla
        float posX = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector2(posX, transform.position.y);
    }

    void DisparoBala()
    {
        // Disparar al presionar la tecla de espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InstanciarBala();
        }
    }

    void InstanciarBala()
    {
        // Instanciar una bala desde el prefab en el punto de disparo
        GameObject bala = Instantiate(balaPrefab, puntoDisparo.position, Quaternion.identity);

        // Aplicar velocidad hacia arriba a la bala
        bala.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, velocidadDisparo);
    }

    // Establecer límites de movimiento horizontal
    private float minX = -5f; 
    private float maxX = 7f;
}

