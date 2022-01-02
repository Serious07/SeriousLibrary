using System;
using UnityEngine;

namespace SeriousLib.UI
{
    public interface IUIScreen
    {
        /// <summary>
        /// Game object of this interface
        /// </summary>
        GameObject go { set; get; }
        Action<IUIScreen> OnShow { set; get; }
        Action<IUIScreen> OnHide { set; get; }
        void ShowScreen();
        void HideScreen();
        void Init();
    }
}