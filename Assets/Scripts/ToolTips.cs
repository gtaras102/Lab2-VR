using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ToolTips : MonoBehaviour
{
    public UnityEvent OnEnter = new UnityEvent();
    public UnityEvent OnExit = new UnityEvent();
    public UnityEvent OnSelect = new UnityEvent();
    public UnityEvent OnDeselect = new UnityEvent();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OnEnter.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        OnExit.Invoke();
    }

    private void OnCollisionEnter(Collision collision)   
    {
        if (gameObject.tag == "Planet")
        {
            OnSelect.Invoke();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        OnDeselect.Invoke();
    }
    public void DestroyTrigger()
    {
        Destroy(gameObject);
    }


}
