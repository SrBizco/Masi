using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public float velocidadMovimiento = 2f;
    public int vidaEnemigo = 100;

    private Transform jugador;

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Movimiento del enemigo hacia el jugador
        Vector3 direccion = (jugador.position - transform.position).normalized;
        transform.Translate(direccion * velocidadMovimiento * Time.deltaTime);
    }

    public void RecibirDanio(int danio)
    {
        vidaEnemigo -= danio;

        if (vidaEnemigo <= 0)
        {
            // El enemigo ha sido derrotado, puedes realizar aquí las acciones necesarias
            Destroy(gameObject);
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

            SceneManager.LoadScene("GameOver");
        }
    }
}

