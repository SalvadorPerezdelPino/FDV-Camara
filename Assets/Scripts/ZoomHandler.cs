using Unity.Cinemachine;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class ZoomHandler : MonoBehaviour
{

    public CinemachineCamera vcam;
    public InputActionReference zoomAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        zoomAction.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        vcam.Lens.OrthographicSize = math.clamp(vcam.Lens.OrthographicSize + zoomAction.action.ReadValue<float>() * Time.deltaTime, 1, 8);
    }
}
