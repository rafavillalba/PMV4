using UnityEngine;

public class Bala : MonoBehaviour
{
    public float tiempoDestruccion = 5f;

    void Start()
    {
        // Destruir el objeto después de cierto tiempo
        Destroy(gameObject, tiempoDestruccion);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Si colisiona con un objeto llamado "Enemigo", destruir el objeto actual
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GameManager.Instance.AumentarContador();
        }
    }
}
