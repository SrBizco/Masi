using UnityEngine;

public class MousePointerController : MonoBehaviour
{
    void Update()
    {
        // Obtener la posici�n del puntero del mouse en pantalla
        Vector3 mousePositionScreen = Input.mousePosition;
        // Convertir la posici�n del puntero del mouse a una posici�n en el mundo del juego
        Vector3 mousePositionWorld = Camera.main.ScreenToWorldPoint(new Vector3(mousePositionScreen.x, mousePositionScreen.y, transform.position.z));
        // Actualizar la posici�n del GameObject del puntero del mouse
        transform.position = new Vector3(mousePositionWorld.x, mousePositionWorld.y, transform.position.z);
    }
}

