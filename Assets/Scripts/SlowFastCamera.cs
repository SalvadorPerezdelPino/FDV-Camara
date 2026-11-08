using Unity.Cinemachine;
using UnityEngine;

public class SlowFastCamera : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "WOOD")
        {
            SlowCamera();
            Destroy(other.gameObject);
        } 
        else if (other.tag == "MEAT")
        {
            FastCamera();
            Destroy(other.gameObject);
        }
    }

    void SlowCamera()
    {
        Time.timeScale = 0.5f;
    }
    
    void FastCamera()
    {
        Time.timeScale = 2f;
    }
}
