using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    // ENCAPSULATION
    private Vector3 Size { get; set; }

    // POLYMORPHISM
    protected override void Start()
    {
        // ABSTRACTION
        base.Start();
        ObjectInfo();
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        string message = string.Format("This is a {0}, it has {1} color with a size of {2} in meters.", ObjName, ColorName, Size);
        textMessage.text = message;
    }

    // POLYMORPHISM
    protected override void ObjectInfo()
    {
        Color = Color.green;
        ColorName = "Green";
        gameObject.GetComponent<Renderer>().material.color = Color;
        Size = GetComponent<BoxCollider>().size;
    }
}
