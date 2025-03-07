using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void playGame()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.ResetGame();
        }

        SceneManager.LoadScene("SampleScene");
    }

    public void ShowExplanation()
    {
        SceneManager.LoadScene("ExplanationScene");
    }

    public void ShowEncuesta()
    {
        SceneManager.LoadScene("EvaluacionFinalScene");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ReturnToOutside()
    {
        SceneManager.LoadScene("OutsideScene");
    }

    public void ReturnToHall()
    {
        Debug.Log("El botón ha sido presionado");
        SceneManager.LoadScene("SampleScene");
    }

    public void ReturnToSecondFloor()
    {
        SceneManager.LoadScene("SecondFloorScene");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
