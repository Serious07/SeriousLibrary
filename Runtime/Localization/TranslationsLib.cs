using System;
using System.Collections.Generic;
using UnityEngine;

namespace SeriousLib.Localization
{
    [Serializable]
    public class TranslationsLib
    {
        public TextAsset afrikaans;
        public TextAsset arabic;
        public TextAsset basque;
        public TextAsset belarusian;
        public TextAsset bulgarian;
        public TextAsset catalan;
        public TextAsset chinese;
        public TextAsset czech;
        public TextAsset danish;
        public TextAsset dutch;
        public TextAsset english;
        public TextAsset estonian;
        public TextAsset faroese;
        public TextAsset finnish;
        public TextAsset french;
        public TextAsset german;
        public TextAsset greek;
        public TextAsset hebrew;
        public TextAsset hungarian;
        public TextAsset icelandic;
        public TextAsset indonesian;
        public TextAsset italian;
        public TextAsset japanese;
        public TextAsset korean;
        public TextAsset latvian;
        public TextAsset lithuanian;
        public TextAsset norwegian;
        public TextAsset polish;
        public TextAsset portuguese;
        public TextAsset romanian;
        public TextAsset russian;
        public TextAsset serboCroatian;
        public TextAsset slovak;
        public TextAsset slovenian;
        public TextAsset spanish;
        public TextAsset swedish;
        public TextAsset thai;
        public TextAsset turkish;
        public TextAsset ukrainian;
        public TextAsset vietnamese;
        public TextAsset chineseSimplified;
        public TextAsset chineseTraditional;

        public Dictionary<SystemLanguage, TextAsset> GetAssetsCollection()
        {
            Dictionary<SystemLanguage, TextAsset> allAssets = new Dictionary<SystemLanguage, TextAsset>();

            foreach(SystemLanguage language in (SystemLanguage[])Enum.GetValues(typeof(SystemLanguage))) {
                switch (language) {
                    case SystemLanguage.Afrikaans:
                        PutAssetInDictionary(ref allAssets, ref afrikaans, language);
                        break;
                    case SystemLanguage.Arabic:
                        PutAssetInDictionary(ref allAssets, ref arabic, language);
                        break;
                    case SystemLanguage.Basque:
                        PutAssetInDictionary(ref allAssets, ref basque, language);
                        break;
                    case SystemLanguage.Belarusian:
                        PutAssetInDictionary(ref allAssets, ref belarusian, language);
                        break;
                    case SystemLanguage.Bulgarian:
                        PutAssetInDictionary(ref allAssets, ref bulgarian, language);
                        break;
                    case SystemLanguage.Catalan:
                        PutAssetInDictionary(ref allAssets, ref catalan, language);
                        break;
                    case SystemLanguage.Chinese:
                        PutAssetInDictionary(ref allAssets, ref chinese, language);
                        break;
                    case SystemLanguage.ChineseSimplified:
                        PutAssetInDictionary(ref allAssets, ref chineseSimplified, language);
                        break;
                    case SystemLanguage.ChineseTraditional:
                        PutAssetInDictionary(ref allAssets, ref chineseTraditional, language);
                        break;
                    case SystemLanguage.Czech:
                        PutAssetInDictionary(ref allAssets, ref czech, language);
                        break;
                    case SystemLanguage.Danish:
                        PutAssetInDictionary(ref allAssets, ref danish, language);
                        break;
                    case SystemLanguage.Dutch:
                        PutAssetInDictionary(ref allAssets, ref dutch, language);
                        break;
                    case SystemLanguage.English:
                        PutAssetInDictionary(ref allAssets, ref english, language);
                        break;
                    case SystemLanguage.Estonian:
                        PutAssetInDictionary(ref allAssets, ref estonian, language);
                        break;
                    case SystemLanguage.Faroese:
                        PutAssetInDictionary(ref allAssets, ref faroese, language);
                        break;
                    case SystemLanguage.Finnish:
                        PutAssetInDictionary(ref allAssets, ref finnish, language);
                        break;
                    case SystemLanguage.French:
                        PutAssetInDictionary(ref allAssets, ref french, language);
                        break;
                    case SystemLanguage.German:
                        PutAssetInDictionary(ref allAssets, ref german, language);
                        break;
                    case SystemLanguage.Greek:
                        PutAssetInDictionary(ref allAssets, ref greek, language);
                        break;
                    case SystemLanguage.Hebrew:
                        PutAssetInDictionary(ref allAssets, ref hebrew, language);
                        break;
                    case SystemLanguage.Hungarian:
                        PutAssetInDictionary(ref allAssets, ref hungarian, language);
                        break;
                    case SystemLanguage.Icelandic:
                        PutAssetInDictionary(ref allAssets, ref icelandic, language);
                        break;
                    case SystemLanguage.Indonesian:
                        PutAssetInDictionary(ref allAssets, ref indonesian, language);
                        break;
                    case SystemLanguage.Italian:
                        PutAssetInDictionary(ref allAssets, ref italian, language);
                        break;
                    case SystemLanguage.Japanese:
                        PutAssetInDictionary(ref allAssets, ref japanese, language);
                        break;
                    case SystemLanguage.Korean:
                        PutAssetInDictionary(ref allAssets, ref korean, language);
                        break;
                    case SystemLanguage.Latvian:
                        PutAssetInDictionary(ref allAssets, ref latvian, language);
                        break;
                    case SystemLanguage.Lithuanian:
                        PutAssetInDictionary(ref allAssets, ref lithuanian, language);
                        break;
                    case SystemLanguage.Norwegian:
                        PutAssetInDictionary(ref allAssets, ref norwegian, language);
                        break;
                    case SystemLanguage.Polish:
                        PutAssetInDictionary(ref allAssets, ref polish, language);
                        break;
                    case SystemLanguage.Portuguese:
                        PutAssetInDictionary(ref allAssets, ref portuguese, language);
                        break;
                    case SystemLanguage.Romanian:
                        PutAssetInDictionary(ref allAssets, ref romanian, language);
                        break;
                    case SystemLanguage.Russian:
                        PutAssetInDictionary(ref allAssets, ref russian, language);
                        break;
                    case SystemLanguage.SerboCroatian:
                        PutAssetInDictionary(ref allAssets, ref serboCroatian, language);
                        break;
                    case SystemLanguage.Slovak:
                        PutAssetInDictionary(ref allAssets, ref slovak, language);
                        break;
                    case SystemLanguage.Slovenian:
                        PutAssetInDictionary(ref allAssets, ref slovenian, language);
                        break;
                    case SystemLanguage.Spanish:
                        PutAssetInDictionary(ref allAssets, ref spanish, language);
                        break;
                    case SystemLanguage.Swedish:
                        PutAssetInDictionary(ref allAssets, ref swedish, language);
                        break;
                    case SystemLanguage.Thai:
                        PutAssetInDictionary(ref allAssets, ref thai, language);
                        break;
                    case SystemLanguage.Turkish:
                        PutAssetInDictionary(ref allAssets, ref turkish, language);
                        break;
                    case SystemLanguage.Ukrainian:
                        PutAssetInDictionary(ref allAssets, ref ukrainian, language);
                        break;
                    case SystemLanguage.Vietnamese:
                        PutAssetInDictionary(ref allAssets, ref vietnamese, language);
                        break;
                }
            }

            return allAssets;
        }

        private void PutAssetInDictionary(ref Dictionary<SystemLanguage, TextAsset> allAssets, ref TextAsset languageAsset, SystemLanguage currentLanguage)
        {
            if (languageAsset != null) {
                allAssets.Add(currentLanguage, languageAsset);
            }
        }
    }
}