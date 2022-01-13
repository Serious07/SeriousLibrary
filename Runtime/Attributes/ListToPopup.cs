using System;
using UnityEngine;

namespace SeriousLib.Attributes
{
    public class ListToPopup : PropertyAttribute
    {
        public Type myType;
        public string propertyName;

        public ListToPopup(Type _myType, string _propertyName)
        {
            myType = _myType;
            propertyName = _propertyName;
        }
    }
}
