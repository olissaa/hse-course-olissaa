
using UnityEngine;

public class UpgradePurchase : MonoBehaviour
{
    private int count = 0;
    public int gold = 500;
    public int costPerLevel = 20;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            count++;

            if (count == 5)
            {
                for (int level = 5; level >= 1; level--)
                {
                    int cost = level * costPerLevel;
                    gold -= cost;

                    Debug.Log(level + "... -" + cost + " gold");
                }

                Debug.Log("Upgrade complete!");
                count = 0;
            }
        }
    }
}

