using UnityEngine;

public class Coin : MonoBehaviour
{
    public int valorMoneda = 1;
    private string coinID;

    private void Start()
    {
        coinID = gameObject.scene.name + "_" + transform.position.x + "_" + transform.position.y;

        if (PlayerPrefs.HasKey(coinID))
        {
            Destroy(gameObject);
        }
    }

    public void RecogerMoneda()
    {
        GameManager.instance.SumarMoneda(valorMoneda);

        PlayerPrefs.SetInt(coinID, 1);
        PlayerPrefs.Save();

        Destroy(gameObject);
    }
}
