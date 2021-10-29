using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Shape : MonoBehaviour
{
    //[Encapsulation]
    protected string ObjName { get; private set; }
    protected string ColorName { get; set; }
    protected Color Color { get; set; }
    [SerializeField] protected Text textMessage;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        ObjName = gameObject.name;
    }

    //[Abstraction]
    protected abstract void DisplayText();

    //[Abstraction]
    protected abstract void ObjectInfo();

    private void OnMouseDown()
    {
        DisplayText();
    }
}
