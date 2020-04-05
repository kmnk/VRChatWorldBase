using UdonSharp;

using UnityEngine;
using UnityEngine.UI;

using VRC.SDKBase;
using VRC.Udon;

using System;

namespace Sandbox
{
    public class SandboxView : UdonSharpBehaviour
    {

        [SerializeField]
        Text clockText;

        public void ShowDateTime(DateTime datetime)
        {
            clockText.text = datetime.ToString();
        }
    }
}
