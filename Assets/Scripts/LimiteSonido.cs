using UnityEngine;

public class LimiteSonido : MonoBehaviour
{
    public AudioSource sonido;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            sonido.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
