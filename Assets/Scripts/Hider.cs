using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.InputSystem;

public class Hider : MonoBehaviour
{
    public Vector3 hidePosition;
    public float hideDistance;
    public Camera gameCamera;

    public float waitDuration;

    public float timePassed = 0f;
    public float timeSinceLastFrame = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Application.targetFrameRate = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        //Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        //worldMousePosition.z = 0f;
        //float distanceToMouse = Vector3.Distance(worldMousePosition, transform.position);

        //if(distanceToMouse < hideDistance)
        //{
        //    transform.position = hidePosition;
        //}
        timeSinceLastFrame = Time.deltaTime;
        timePassed += Time.deltaTime;
        if(timePassed > waitDuration)
        {
            transform.position = hidePosition;
        }

    }
}
