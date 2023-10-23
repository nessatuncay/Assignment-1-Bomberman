using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlapTag : MonoBehaviour
{
    public enum Type
    {
        None,
        Speed_Up,
        Speed_Down, 
    }

    public Type type = Type.None;
}
