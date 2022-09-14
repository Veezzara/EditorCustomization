using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeObjectWithEditor : MonoBehaviour
{
    public enum SomeEnum
    {
        option1, option2, option3, option4
    }

    [Header("Object Properties")]
    [Range(0, 10)] public int i = 10;
    public float f = 20.5f;
    public string s = "Some String!";
    public SomeEnum m = SomeEnum.option1;
}
