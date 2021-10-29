using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Capsule : Shape
{
    // ENCAPSULATION
    private float Radius { get; set; }
    private float Height { get; set; }

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
        string message = string.Format("This is a {0}, it has {1} color with a {2} meter radius and a height of {3} meters.", ObjName, ColorName, Radius, Height);
        textMessage.text = message;
    }

    // POLYMORPHISM
    protected override void ObjectInfo()
    {
        Color = Color.blue;
        ColorName = "Blue";
        gameObject.GetComponent<Renderer>().material.color = Color;
        Radius = GetComponent<CapsuleCollider>().radius;
        Height = GetComponent<CapsuleCollider>().height;
    }
}
