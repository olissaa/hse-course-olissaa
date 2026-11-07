
using UnityEngine;

public class MarkerHighlighter : MonoBehaviour
{
    public GameObject[] markers;

    void Start()
    {
        foreach (GameObject marker in markers)
        {
            Renderer r = marker.GetComponent<Renderer>();

            if (r != null)
            {
                r.material.color = Color.green;
            }
            else
            {
                Debug.Log(marker.name + " has no Renderer");
            }
        }
    }
}
