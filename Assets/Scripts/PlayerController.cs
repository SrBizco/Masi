using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public GameObject balaPrefab;
    public float velocidadDisparo = 0.5f;

    private float tiempoUltimoDisparo = 0f;
    public int vida = 100;
    void Update()
    {

        Vector3 mousePositionScreen = Input.mousePosition;

        Vector3 mousePositionWorld = Camera.main.ScreenToWorldPoint(new Vector3(mousePositionScreen.x, mousePositionScreen.y, transform.position.z));
        
        Vector3 direccion = mousePositionWorld - transform.position;
        direccion.z = 0; 
        
        transform.up = direccion.normalized;

        
        if (Input.GetButton("Fire1") && Time.time > tiempoUltimoDisparo + velocidadDisparo)
        {
            Disparar();
            tiempoUltimoDisparo = Time.time;
        }
    }

    void Disparar()
    {
        
        Instantiate(balaPrefab, transform.position, transform.rotation);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
          
            SceneManager.LoadScene("GameOver");
        }
    }
}