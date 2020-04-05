using UdonSharp;

using UnityEngine;

using VRC.SDKBase;
using VRC.Udon;

using System;

namespace Sandbox
{
    public class SandboxBehaviour : UdonSharpBehaviour
    {
        [SerializeField]
        SandboxView view;

        void Update()
        {

            view.ShowDateTime(GetDateTime());
        }

        DateTime GetDateTime()
        {
            return DateTime.Now;
        }

    }
}
