using Unity.Cinemachine;
using Unity.VisualScripting;
using UnityEngine;

public class CameraPriorityHandler : MonoBehaviour
{
    public CinemachineCamera cam1, cam2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam1.Priority = 9;
        cam2.Priority = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Tower")
        {
            int priority = cam1.Priority;
            cam1.Priority = cam2.Priority;
            cam2.Priority = priority;
        }
    }
}
