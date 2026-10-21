
using UnityEngine;

public class PressCounter : MonoBehaviour
{
    private int count = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count++;

            Debug.Log("Press count: " + count);

            if (count == 5)
            {
                Debug.Log("Five presses reached!");
            }
        }
    }
}

