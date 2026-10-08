using UnityEngine;

public class powerUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // Aquí puedes agregar la lógica para aplicar el efecto del power-up al jugador
            Debug.Log("Power-up recogido por el jugador");
            Destroy(gameObject); // Destruye el power-up después de ser recogido
        }
    }
}
