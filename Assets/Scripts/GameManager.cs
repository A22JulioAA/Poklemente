using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para detectar cambios de escena

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int coins = 0;
    public TextMeshProUGUI coinsText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        ResetGame();
        BuscarUI();
        ActualizarUI();
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        BuscarUI();
        ActualizarUI();
    }

    private void BuscarUI()
    {
        if (coinsText == null)
        {
            coinsText = FindObjectOfType<TextMeshProUGUI>();
        }
    }

    public void ActualizarUI()
    {

        if (coinsText != null)
        {
            coinsText.text = "" + coins.ToString();
        }
        else
        {
            Debug.LogWarning("coinsText no asignado o no encontrado.");
        }
    }

    public void SumarMoneda(int cantidad)
    {
        coins += cantidad;
        ActualizarUI();
    }

    public void ResetGame()
    {
        coins = 0;
        PlayerPrefs.DeleteKey("monedas");
    }

    public void RestartGame()
    {
        coins = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
