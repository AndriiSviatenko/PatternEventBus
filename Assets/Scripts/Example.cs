using System;
using Patterns.EventBus;
using Patterns.EventBus.Events;
using UnityEngine;

public class Example : MonoBehaviour
{
    private bool _isAlive;

    private void Update()
    {
        if (!_isAlive)
        {
            EventBus.Instance.Invoke(new DeadEvent<Example>(this));
        }
    }
}