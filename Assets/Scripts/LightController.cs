using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light pointLight;

    void Start()
    {
        // Get a reference to the point light component
        pointLight = GetComponent<Light>();
    }

    void Update()
    {
        // Check for input to turn the light on and off
        if (Input.GetKeyDown(KeyCode.F))
        {
            pointLight.enabled = !pointLight.enabled;
        }
    }
}