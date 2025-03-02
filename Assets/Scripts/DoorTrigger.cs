using System.Collections;
using TMPro;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public TextMeshProUGUI zoneText;
    public string defaultZoneName = "Zona Desconocida";

    private void Start()
    {
        zoneText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ShowZoneName(defaultZoneName);
            ZoneManager.Instance.lastZone = defaultZoneName;
        }
    }

    private void ShowZoneName(string name)
    {
        StopAllCoroutines();
        zoneText.text = name;
        zoneText.gameObject.SetActive(true);
        StartCoroutine(HideTextAfterSeconds(5));
    }

    private IEnumerator HideTextAfterSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        zoneText.gameObject.SetActive(false);
    }
}
