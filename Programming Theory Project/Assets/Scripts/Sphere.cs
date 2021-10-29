using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    //[Encapsulation]
    private float Radius { get; set; }

    //[Polymorphism]
    protected override void Start()
    {
        base.Start();
        ObjectInfo();
    }

    protected override void DisplayText()
    {
        string message = string.Format("This is a {0}, it has {1} color with a radius of {2} meters.", ObjName, ColorName, Radius);
        textMessage.text = message;
    }

    //[Polymorphism]
    protected override void ObjectInfo()
    {
        Color = Color.red;
        ColorName = "Red";
        gameObject.GetComponent<Renderer>().material.color = Color;
        Radius = gameObject.GetComponent<SphereCollider>().radius;
    }
}
