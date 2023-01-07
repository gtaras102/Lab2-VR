using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VRButton : MonoBehaviour
{
    public float dedTime = 1.0f;
    private bool _deadTimeActive = false;

    public UnityEvent onPressed, onReleassed;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Button" && !_deadTimeActive)
        {
            onPressed?.Invoke();
            Debug.Log("I have been pressed!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Button" && !_deadTimeActive)
        {
            onReleassed?.Invoke();
            Debug.Log("I have been releassed!");
        }
    }
}
