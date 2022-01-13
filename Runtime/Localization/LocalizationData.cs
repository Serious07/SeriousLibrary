using SeriousLib.Singleton;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace SeriousLib.Localization
{
    [DefaultExecutionOrder(0)]
    public class LocalizationData : SingletonMono<LocalizationData>
    {
        [SerializeField] private SystemLanguage languageByDefault = SystemLanguage.English;
        [SerializeField] private SystemLanguage currentLanguage = SystemLanguage.Unknown;

        [SerializeField] private TranslationsLib translations;
        [SerializeField] private bool autoDetectLanguage = false;

        private Dictionary<string, Dictionary<SystemLanguage, string>> keyTranslations = 
            new Dictionary<string, Dictionary<SystemLanguage, string>>();

        public override void Awake()
        {
            base.Awake();

            Init();

            if (autoDetectLanguage) {
                currentLanguage = Application.systemLanguage;
            }
        }

        private void Init()
        {
            Dictionary<SystemLanguage, TextAsset> allAssets = translations.GetAssetsCollection();
            fillKeyTranslations(ref allAssets, ref keyTranslations);
        }

        private void fillKeyTranslations(ref Dictionary<SystemLanguage, TextAsset> allAssets, 
                                         ref Dictionary<string, Dictionary<SystemLanguage, string>> keyTranslations)
        {
            foreach(SystemLanguage language in (SystemLanguage[])Enum.GetValues(typeof(SystemLanguage))) {
                if (allAssets.ContainsKey(language)) {
                    Dictionary<string, string> keyValuesForLanguage = TextParser.GetLocalizationFromFile(allAssets[language]);

                    foreach (KeyValuePair<string, string> keyValue in keyValuesForLanguage) {
                        if (keyTranslations.ContainsKey(keyValue.Key)){
                            Dictionary<SystemLanguage, string> currectTranslationsForKey = keyTranslations[keyValue.Key];

                            if(currectTranslationsForKey.ContainsKey(language) == false) {
                                currectTranslationsForKey.Add(language, keyValue.Value);
                            }

                            keyTranslations[keyValue.Key] = currectTranslationsForKey;
                        } else {
                            Dictionary<SystemLanguage, string> currectTranslationsForKey = new Dictionary<SystemLanguage, string>();
                            currectTranslationsForKey.Add(language, keyValue.Value);
                            keyTranslations.Add(keyValue.Key, currectTranslationsForKey);
                        }
                    }
                }
            }
        }

        public string GetLocalizedText(string key, SystemLanguage language)
        {
            if (keyTranslations.ContainsKey(key) && keyTranslations[key].ContainsKey(language)) {
                return keyTranslations[key][language];
            } else if (keyTranslations.ContainsKey(key)) {
                return keyTranslations[key][languageByDefault];
            } else {
                return "Key not set!";
            }
        }

        public string GetLocalizedText(string key)
        {
            if (keyTranslations.ContainsKey(key) && keyTranslations[key].ContainsKey(currentLanguage)) {
                return keyTranslations[key][currentLanguage];
            } else if (keyTranslations.ContainsKey(key)) {
                return keyTranslations[key][languageByDefault];
            } else {
                return "Key not set!";
            }
        }

        public List<string> GetAllKeys() {
            List<string> result = new List<string>();

            Init();

            foreach (KeyValuePair<string, Dictionary<SystemLanguage, string>> keyValue in keyTranslations) {
                result.Add(keyValue.Key);
            }

            return result;
        }
    }
}
