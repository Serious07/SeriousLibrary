#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SeriousLib.Attributes
{
    [CustomPropertyDrawer(typeof(ListToPopup))]
    public class ListToPopupDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            ListToPopup listToPopup = attribute as ListToPopup;
            List<string> stringList = null;

            if(listToPopup.myType.GetField(listToPopup.propertyName) != null) {
                stringList = listToPopup.myType.GetField(listToPopup.propertyName).GetValue(listToPopup.myType) as List<string>;
            }

            if(stringList != null && stringList.Count != 0) {
                int selectedIndex = Mathf.Max(stringList.IndexOf(property.stringValue), 0);
                selectedIndex = EditorGUI.Popup(position, property.name, selectedIndex, stringList.ToArray());
                property.stringValue = stringList[selectedIndex];
            } else {
                EditorGUI.PropertyField(position, property, label);
            }
        }
    }
}
#endif