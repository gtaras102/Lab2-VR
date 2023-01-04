using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ToolTips : MonoBehaviour
{
    public GameObject player;

    public UnityEvent OnEnter = new UnityEvent();
    public UnityEvent OnExit = new UnityEvent();

    //public UnityEvent OnActivate = new UnityEvent();

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
        //Destroy(this);
    }



}
