using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraSelector : MonoBehaviour
{

    public InputActionReference previousCameraAction;
    public InputActionReference nextCameraAction;

    public List<GameObject> cameras;

    int index = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SelectCamera(index);
        previousCameraAction.action.Enable();
        nextCameraAction.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (previousCameraAction.action.WasPressedThisFrame())
        {
            index = (index - 1 + cameras.Count) % cameras.Count;
            SelectCamera(index);
        }
        if (nextCameraAction.action.WasPressedThisFrame())
        {
            index = (index + 1) % cameras.Count;
            SelectCamera(index);
        }
    }

    public void SelectCamera(int index)
    {
        for (int i = 0; i < cameras.Count; i++)
        {
            if (i == index)
            {
                cameras[i].SetActive(true);
                continue;
            }
            cameras[i].SetActive(false);
        }
    }
}
