using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DracarysController : MonoBehaviour
{
    [SerializeField] private float speed;

    private FixedJoystick fixedJoystick;
    private Rigidbody rigidBody;

    private void OnEnable()
    {
        fixedJoystick = FindObjectOfType<FixedJoystick>();
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float xVal = fixedJoystick.Horizontal;
        float zVal = fixedJoystick.Vertical;

        Vector3 movement = new Vector3(xVal, 0, zVal);
        rigidBody.velocity= movement * speed;

        if(xVal != 0 && zVal != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(xVal, zVal)*Mathf.Rad2Deg, transform.eulerAngles.z);
        }
    }
}
