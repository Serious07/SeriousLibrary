using SeriousLib.Attributes;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SeriousLib.Localization
{
    [RequireComponent(typeof(TextMeshProUGUI)), DefaultExecutionOrder(100)]
    public class TextLocalizerTMPro : MonoBehaviour, ISerializationCallbackReceiver
    {
        #region Popup vars
        public static List<string> tmpAllKeys;
        [HideInInspector] public List<string> allKeys;
        #endregion

        [SerializeField, ListToPopup(typeof(TextLocalizer), "tmpAllKeys")]
        private string key;

        private TextMeshProUGUI textElement;

        #region ISerializationCallbackReceiver
        public void OnAfterDeserialize()
        {
        }

        public void OnBeforeSerialize()
        {
            UpdateKeys();
            UpdateText();
        }
        #endregion

        public void OnValidate()
        {
            UpdateKeys();
            UpdateText();
        }

        [ContextMenu("Update keys")]
        public void UpdateKeys()
        {
            allKeys = LocalizationData.instance.GetAllKeys();
            tmpAllKeys = allKeys;
        }

        private void Awake()
        {
            UpdateText();
        }

        private void UpdateText()
        {
            textElement = GetComponent<TextMeshProUGUI>();
            textElement.text = LocalizationData.instance.GetLocalizedText(key);
        }
    }
}
