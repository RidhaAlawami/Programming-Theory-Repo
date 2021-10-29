using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[inheritance]
public class Cube : Shape
{
    //[Encapsulation]
    private Vector3 Size { get; set; }

    //[Polymorphism]
    protected override void Start()
    {
        base.Start();
        ObjectInfo();
    }

    //[Polymorphism]
    protected override void DisplayText()
    {
        string message = string.Format("This is a {0}, it has {1} color with a size of {2} in meters.", ObjName, ColorName, Size);
        textMessage.text = message;
    }

    //[Polymorphism]
    protected override void ObjectInfo()
    {
        Color = Color.green;
        ColorName = "Green";
        gameObject.GetComponent<Renderer>().material.color = Color;
        Size = GetComponent<BoxCollider>().size;
    }
}
