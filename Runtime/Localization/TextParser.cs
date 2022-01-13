using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace SeriousLib.Localization
{
    public class TextParser
    {
        private const string SEPARATOR = " := ";

        public static Dictionary<string, string> GetLocalizationFromFile(TextAsset textAsset)
        {
            string[] lines = Regex.Split(textAsset.text, "\n|\r|\r|\n");
            return GetLocalizaton(lines);
        }

        public static Dictionary<string, string> GetLocalizaton(string[] fileText)
        {
            Dictionary<string, string> result;

            if(fileText != null && fileText.Length > 0) {
                result = new Dictionary<string, string>();
            } else {
                return null;
            }

            for (int i = 0; i < fileText.Length; i++) {
                string[] values = 
                    fileText[i].Split(new string[] { SEPARATOR }, System.StringSplitOptions.None);

                if(values != null && values.Length == 2) {
                    result.Add(values[0], values[1]);
                }
            }

            return result;
        }
    }
}