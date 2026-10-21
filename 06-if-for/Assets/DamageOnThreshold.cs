
using UnityEngine;

public class DamageOnThreshold : MonoBehaviour
{
    private int count = 0;
    public int baseDamage = 7;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            count++;

            if (count == 3)
            {
                for (int level = 1; level <= 5; level++)
                {
                    int damage = baseDamage * level;
                    Debug.Log(baseDamage + " x " + level + " = " + damage);
                }

                Debug.Log("---");
                count = 0;
            }
        }
    }
}

