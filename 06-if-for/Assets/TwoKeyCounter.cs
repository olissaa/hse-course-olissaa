
using UnityEngine;

public class TwoKeyCounter : MonoBehaviour
{
    private int count = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            count++;
            Debug.Log("Count: " + count);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            count--;
            Debug.Log("Count: " + count);
        }

        if (count < 0)
        {
            Debug.Log("Negative!");
            count = 0;
        }

        if (count >= 5)
        {
            Debug.Log("Max reached!");
            count = 0;
        }
    }
}

