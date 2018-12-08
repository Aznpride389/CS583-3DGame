using UnityEngine;
using System.Collections;

public class CameraTracker : MonoBehaviour
{
    public GameObject player;
    private Vector3 playerSafeSpace;

    // Use this for initialization
    void Start()
    {
        playerSafeSpace = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.position = player.transform.position + playerSafeSpace;
    }
}
