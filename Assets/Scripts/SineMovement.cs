using UnityEngine;

public class SineMovement : MonoBehaviour
{
    float time = 0.0f;
    public float amplitudeX = 2.0f;
    public float amplitudeY = 1.0f;
    public float phase = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Mathf.Sin(time + phase) * amplitudeX, Mathf.Sin(time + phase) * amplitudeY, 0) * Time.deltaTime);
        time += Time.deltaTime;
    }
}
