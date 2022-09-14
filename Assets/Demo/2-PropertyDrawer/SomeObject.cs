using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeObject : MonoBehaviour
{
    public enum SomeEnum
    {
        option1, option2, option3, option4
    }

    public int i = 10;
    public float f = 20f;
    public string s = "Some String!";
    public SomeEnum m = SomeEnum.option1;
    [Range(0, 10)] public int i2 = 10;
}
