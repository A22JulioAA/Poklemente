using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;
    [SerializeField] private bool requireCoins = false;
    [SerializeField] private int requiredCoins = 100;
    [SerializeField] private string sceneIfNotEnoughCoins;

    void Start()
    {
        // Asegúrate de que el GameManager está presente y no es null
        if (GameManager.instance == null)
        {
            Debug.LogError("GameManager instance is not found!");
        }
    }

    void Update()
    {
        // Aquí también podrías poner cualquier otra lógica que necesites
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameManager.instance != null)
            {
                if (requireCoins)
                {
                    if (GameManager.instance.coins >= requiredCoins)
                    {
                        SceneManager.LoadScene(sceneToLoad);
                    }
                    else
                    {
                        SceneManager.LoadScene(sceneIfNotEnoughCoins);
                    }
                }
                else
                {
                    SceneManager.LoadScene(sceneToLoad);
                }
            }
            else
            {
                Debug.LogError("GameManager instance is not initialized!");
            }
        }
    }
}
