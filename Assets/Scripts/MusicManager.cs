using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;
    public AudioSource audioSource;

    public AudioClip musicaMenu;
    public AudioClip musicaJuego;
    public AudioClip musicaFinal;

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

        audioSource = GetComponent<AudioSource>();

        CambiarMusica(SceneManager.GetActiveScene().name);
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
        CambiarMusica(scene.name);
    }

    private void CambiarMusica(string nombreEscena)
    {
        if (nombreEscena == "MainMenu")
        {
            if (audioSource.clip != musicaMenu)
            {
                audioSource.clip = musicaMenu;
                audioSource.Play();
            }
        }
        else if (nombreEscena != "ArcaDaVellaFinalScene")
        {
            if (audioSource.clip != musicaJuego)
            {
                audioSource.clip = musicaJuego;
                audioSource.Play();
            }
        }
        else if (nombreEscena == "ArcaDaVellaFinalScene")
        {
            if (audioSource.clip != musicaFinal)
            {
                audioSource.clip = musicaFinal;
                audioSource.Play();
            }
        }
    }
}
