using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class TriggerBehavior : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent;
    private void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke(); //.Invoke(); calls the event
    }

    private void OnTriggerStay(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }
}
