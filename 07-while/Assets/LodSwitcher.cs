
using UnityEngine;

public class LodSwitcher : MonoBehaviour
{
    public GameObject[] lodLevels;
    public int lod = 2;

    void Start()
    {
        for (int i = 0; i < lodLevels.Length; i++)
        {
            string title = i switch
            {
                0 => "High detail",
                1 => "Medium detail",
                2 => "Low detail",
                _ => "Unknown"
            };

            bool active = (i == lod);

            lodLevels[i].SetActive(active);

            Debug.Log(title + ": " + (active ? "ON" : "OFF"));
        }
    }
}

