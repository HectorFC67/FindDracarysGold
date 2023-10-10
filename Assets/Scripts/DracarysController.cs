using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DracarysController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float speedAltitude;
    [SerializeField] private FixedJoystick fixedJoystick;
    [SerializeField] private FixedJoystick fixedJoystick1;
    private Rigidbody rigidBody;

    private void OnEnable()
    {
        fixedJoystick = FindObjectsOfType<FixedJoystick>()[0];
        fixedJoystick1 = FindObjectsOfType<FixedJoystick>()[1];
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float xVal = fixedJoystick.Horizontal;
        float zVal = fixedJoystick.Vertical;

        float yVal = fixedJoystick1.Vertical;

        Vector3 movement = new Vector3(xVal, yVal, zVal);
        rigidBody.velocity = movement * speed;

        if (xVal != 0 && zVal != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(xVal, zVal) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
        if (yVal != 0)
        {
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
    }
}