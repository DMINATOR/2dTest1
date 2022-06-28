using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Actors
{
    public class Player : MonoBehaviour
    {
        //Exposed

        [Header("Locator")]

        [Tooltip("Locator")]
        public PlayerLocator Locator;

        // Status

        [Header("Status")]
        public PlayerState State;
    }
}
