using UdonSharp;

using UnityEngine;
using UnityEngine.UI;

using VRC.SDKBase;
using VRC.Udon;

using System;

namespace Sandbox
{
    public class DateTimeBehaviour : UdonSharpBehaviour
    {

        [SerializeField]
        Text toStringText;

        [SerializeField]
        Text toStringFormatText;

        [SerializeField]
        InputField formatInputField;

        // SEE: https://docs.microsoft.com/ja-jp/dotnet/api/system.datetime.tostring?view=netframework-4.8
        const string formatString = "yyyy/MM/dd(dddd) hh:mm:ss";

        void Start()
        {
            formatInputField.text = formatString;
        }

        void Update()
        {

            toStringText.text = DateTime.Now.ToString();
            toStringFormatText.text = DateTime.Now.ToString(formatInputField.text);
        }

    }
}
