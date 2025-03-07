using UnityEngine;

public class Coin : MonoBehaviour
{
    public int valorMoneda = 1;
    private string coinID;
    private AudioSource sonidoMoneda;

    private void Start()
    {
        sonidoMoneda = GetComponent<AudioSource>();

        coinID = gameObject.scene.name + "_" + transform.position.x + "_" + transform.position.y;

        if (PlayerPrefs.GetInt(coinID, 0) == 1)
        {
            Destroy(gameObject);
        }
    }

    public void RecogerMoneda()
    {
        GameManager.instance.SumarMoneda(valorMoneda);

        PlayerPrefs.SetInt(coinID, 1);
        PlayerPrefs.Save();

        if (sonidoMoneda != null)
        {
            sonidoMoneda.Play();
            Destroy(gameObject, sonidoMoneda.clip.length);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
