
using UnityEngine;

public class DistanceZone : MonoBehaviour
{
    public Transform user;
    public Transform target;

    void Start()
    {
        float distance = Vector3.Distance(user.position, target.position);

        string zone = distance switch
        {
            < 1f => "too close",
            < 3f => "near",
            < 10f => "mid",
            _ => "far"
        };

        Debug.Log("Distance: " + distance + ", zone: " + zone);

        if (zone == "too close")
        {
            Debug.Log("Warning: object is too close!");
        }
    }
}

