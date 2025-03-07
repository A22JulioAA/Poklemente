using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EncuestaFinal : MonoBehaviour
{
    public Slider sliderPregunta1;
    public TextMeshProUGUI textoValorPregunta1;

    public Slider sliderPregunta2;
    public TextMeshProUGUI textoValorPregunta2;

    public Slider sliderPregunta3;
    public TextMeshProUGUI textoValorPregunta3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ActualizarTextoSlider1(sliderPregunta1.value);
        ActualizarTextoSlider2(sliderPregunta2.value);
        ActualizarTextoSlider3(sliderPregunta3.value);

        sliderPregunta1.onValueChanged.AddListener(ActualizarTextoSlider1);
        sliderPregunta2.onValueChanged.AddListener(ActualizarTextoSlider2);
        sliderPregunta3.onValueChanged.AddListener(ActualizarTextoSlider3);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ActualizarTextoSlider1(float valor)
    {
        textoValorPregunta1.text = valor.ToString("0");
    }

    public void ActualizarTextoSlider2(float valor)
    {
        textoValorPregunta2.text = valor.ToString("0");
    }

    public void ActualizarTextoSlider3(float valor)
    {
        textoValorPregunta3.text = valor.ToString("0");
    }

}
