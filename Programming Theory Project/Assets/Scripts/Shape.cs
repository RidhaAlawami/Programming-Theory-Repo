using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    protected string ObjName { get; private set; }
    protected string ColorName { get; set; }
    protected Color Color { get; set; }
    [SerializeField] protected Text textMessage;

    protected virtual void Start()
    {
        ObjName = gameObject.name;
    }

    protected abstract void DisplayText();

    protected abstract void ObjectInfo();

    private void OnMouseDown()
    {
        // ABSTRACTION
        DisplayText();
    }
}
