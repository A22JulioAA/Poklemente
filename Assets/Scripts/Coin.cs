using UnityEditor.Build.Content;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int valorMoneda = 1;

    public void RecogerMoneda()
    {
        GameManager.instance.SumarMoneda(valorMoneda);
        Destroy(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
