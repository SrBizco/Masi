using UnityEngine;

public class MousePointerController : MonoBehaviour
{
    void Update()
    {
        // Obtener la posición del puntero del mouse en pantalla
        Vector3 mousePositionScreen = Input.mousePosition;
        // Convertir la posición del puntero del mouse a una posición en el mundo del juego
        Vector3 mousePositionWorld = Camera.main.ScreenToWorldPoint(new Vector3(mousePositionScreen.x, mousePositionScreen.y, transform.position.z));
        // Actualizar la posición del GameObject del puntero del mouse
        transform.position = new Vector3(mousePositionWorld.x, mousePositionWorld.y, transform.position.z);
    }
}

