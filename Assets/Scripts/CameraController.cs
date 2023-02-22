using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.InputSystem;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        // subtract position of camera from player position
        offset = transform.position - player.transform.position;
    }

    // all physics calculations happen in FixedUpdate
    void FixedUpdate()
    {
        // each frame we update the position of the camera
        transform.position = player.transform.position + offset;
    }
}
