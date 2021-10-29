using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    // ENCAPSULATION
    private float Radius { get; set; }

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
        string message = string.Format("This is a {0}, it has {1} color with a radius of {2} meters.", ObjName, ColorName, Radius);
        textMessage.text = message;
    }

    // POLYMORPHISM
    protected override void ObjectInfo()
    {
        Color = Color.red;
        ColorName = "Red";
        gameObject.GetComponent<Renderer>().material.color = Color;
        Radius = gameObject.GetComponent<SphereCollider>().radius;
    }
}
