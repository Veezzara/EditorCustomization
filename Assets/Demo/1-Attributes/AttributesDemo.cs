using System;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Demo.Attributes
{
    public class AttributesDemo : MonoBehaviour
    {
        public void Start()
        {
            var someClass = new SomeClass();
            ClassPrinter.Print(someClass);

            #region (* ^ ? ^)
            //var method = someClass.GetType()
            //    .GetMethod("PrintMessage", BindingFlags.NonPublic | BindingFlags.Instance);
            //method.Invoke(someClass, null);
            #endregion
        }
    }

    public class SomeClass
    {
        [Printable] private int i;
        [Printable] private string s;
        [Printable] public bool b;
        public float f;

        public SomeClass()
        {
            i = 10;
            s = "string";
            b = true;
            f = 10f;
        }

        private void PrintMessage()
        {
            Debug.Log("Message from SomeClass!");
        }
    }

    public static class ClassPrinter
    {
        public static void Print(object someObject)
        {
            var fields = someObject.GetType()
                .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(field => field.IsDefined(typeof(PrintableAttribute)));

            var printedObject = "";
            printedObject += "Name: " + someObject.GetType().Name;


            foreach (var field in fields)
            {
                printedObject += "\n\t";
                printedObject += field.Name + ": " + field.GetValue(someObject);
            }

            Debug.Log(printedObject);
        }
    }

    public class PrintableAttribute : Attribute
    {
    }
}