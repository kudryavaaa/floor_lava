using UnityEngine;
using System.Collections;

public class GenericsSomeOtherClass : MonoBehaviour
{
    void Start()
    {
        GenericsSomeClass myClass = new GenericsSomeClass();

        myClass.GenericMethod<int>(5);
    }
}

