using UnityEngine;

public class ZoneManager : MonoBehaviour
{
    public static ZoneManager Instance { get; private set; }
    public string lastZone = "";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetInitialZone(string zoneName)
    {
        if (string.IsNullOrEmpty(lastZone))
        {
            lastZone = zoneName;
        }
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
