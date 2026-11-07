
using UnityEngine;

public class ChargeColor : MonoBehaviour
{
    public Renderer indicator;
    public int charge = 0;

    void Start()
    {
        while (charge < 100)
        {
            charge += 25;

            if (charge < 50)
            {
                indicator.material.color = Color.red;
            }
            else if (charge < 100)
            {
                indicator.material.color = Color.yellow;
            }
            else
            {
                indicator.material.color = Color.green;
            }

            Debug.Log("Charge: " + charge + "%");
        }
    }
}
