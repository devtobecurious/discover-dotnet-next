using System;

namespace MyAttributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ToGenerateMoreAttribute : Attribute
    {
    }
}
