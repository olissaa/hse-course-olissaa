
using UnityEngine;

public class ControllerState : MonoBehaviour
{
    public Renderer indicator;
    public int mode = 2;

    void Start()
    {
        string name = mode switch
        {
            0 => "Idle",
            1 => "Tracking",
            2 => "Menu",
            3 => "Paused",
            _ => "Unknown"
        };

        Color color = mode switch
        {
            0 => Color.gray,
            1 => Color.green,
            2 => Color.blue,
            3 => Color.yellow,
            _ => Color.red
        };

        indicator.material.color = color;

        Debug.Log("Mode: " + name);
    }
}
