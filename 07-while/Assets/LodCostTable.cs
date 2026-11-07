
using UnityEngine;

public class LodCostTable : MonoBehaviour
{
    public GameObject[] lodLevels;

    void Start()
    {
        int totalCost = 0;

        foreach (GameObject level in lodLevels)
        {
            string name = level.name;

            int cost = name switch
            {
                "High" => 100,
                "Medium" => 50,
                "Low" => 20,
                _ => 0
            };

            totalCost += cost;

            Debug.Log(name + " -> cost " + cost);
        }

        Debug.Log("Total cost: " + totalCost);
    }
}
