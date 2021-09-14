using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampRotate : MonoBehaviour
{
    public float minX = -45, maxX = 45;
    public float minY = -45, maxY = 45;
    Vector3 local_euler;

    [SerializeField] private LayerMask targetLayer;
    [SerializeField] private float rotationRate = 3.0f;
    [SerializeField] private bool xRotation;
    [SerializeField] private bool yRotation;
    [SerializeField] private bool invertX;
    [SerializeField] private bool invertY;
    [SerializeField] private bool touchAnywhere;
    private float m_previousX;
    private float m_previousY;
    private Camera m_camera;
    private bool m_rotating = false;

    void Awake()
    {
        m_camera = Camera.main;
    }


    void Update()
    {
        if (!touchAnywhere)
        {
            //No need to check if already rotating
            if (!m_rotating)
            {
                RaycastHit hit;
                Ray ray = m_camera.ScreenPointToRay(Input.mousePosition);
                if (!Physics.Raycast(ray, out hit, 1000, targetLayer))
                {
                    return;
                }
            }
        }


        local_euler = transform.localEulerAngles;
        local_euler.x = ClampAngle(local_euler.x, minX, maxX);
        local_euler.y = ClampAngle(local_euler.y, minY, maxY);
        local_euler.z = 0;
        transform.localEulerAngles = local_euler;

        // Input
        if (Input.GetMouseButtonDown(0))
        {
            m_rotating = true;
            m_previousX = Input.mousePosition.x;
            m_previousY = Input.mousePosition.y;
        }
        // get the user touch input
        if (Input.GetMouseButton(0))
        {
            //var touch = Input.mousePosition;
            //var deltaX = -(Input.mousePosition.y - m_previousY) * rotationRate;
            //var deltaY = -(Input.mousePosition.x - m_previousX) * rotationRate;




            //transform.Rotate(deltaX, deltaY, 0, Space.World);

            local_euler.x = -(Input.mousePosition.y - m_previousY) * rotationRate;
            local_euler.y = -(Input.mousePosition.x - m_previousX) * rotationRate;

            if (!yRotation) local_euler.x = 0;
            if (!xRotation) local_euler.y = 0;
            if (invertX) local_euler.x *= -1;
            if (invertY) local_euler.y *= -1;

            transform.Rotate(local_euler.x, local_euler.y, 0, Space.World);

            m_previousX = Input.mousePosition.x;
            m_previousY = Input.mousePosition.y;
        }
        if (Input.GetMouseButtonUp(0))
            m_rotating = false;
    }

    float ClampAngle(float angle, float min, float max)
    {
        // accepts e.g. -80, 80
        if (angle < 0f) angle = 360 + angle;
        if (angle > 180f) return Mathf.Max(angle, 360 + min);
        return Mathf.Min(angle, max);
    }
}
