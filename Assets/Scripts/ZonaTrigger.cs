using UnityEngine;
using UnityEngine.UI;  // Para acceder a UI components

public class ZoneTrigger : MonoBehaviour
{
    [SerializeField] private string zoneName = "Zona por defecto";  
    [SerializeField] private Text messageText;  

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  
        {
            ShowMessage(zoneName);
        }
    }

    private void ShowMessage(string message)
    {
        messageText.text = message;  
    }
}
