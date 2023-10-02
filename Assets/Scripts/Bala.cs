using UnityEngine;

public class Bala : MonoBehaviour
{
    public int danio = 10;
    public float velocidadBala = 10f;
    void Update()
    {
        
        transform.Translate(Vector2.up * Time.deltaTime * velocidadBala);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            
            collision.GetComponent<EnemyController>().RecibirDanio(danio);
            Destroy(gameObject);
        }
    }
}
