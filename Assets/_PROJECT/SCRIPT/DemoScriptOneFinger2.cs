//
// Fingers Gestures
// (c) 2015 Digital Ruby, LLC
// Source code may be used for personal or commercial projects.
// Source code may NOT be redistributed or sold.
// 

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DigitalRubyShared
{
    /// <summary>
    /// One finger rotate and scale demo script
    /// </summary>
    public class DemoScriptOneFinger2 : MonoBehaviour
    {
        /// <summary>
        /// Rotate icon
        /// </summary>
        [Tooltip("Rotate icon")]
        public GameObject RotateIcon;

        /// <summary>
        /// Scale icon
        /// </summary>
        

        /// <summary>
        /// The earth, or object to rotate and scale
        /// </summary>
        [Tooltip("The earth, or object to rotate and scale")]
        public GameObject Objects;

        private OneTouchRotateGestureRecognizer rotationGesture = new OneTouchRotateGestureRecognizer();
      

        private void RotationGestureUpdated(DigitalRubyShared.GestureRecognizer gesture)
        {
            if (gesture.State == GestureRecognizerState.Executing)
            {
                Objects.transform.Rotate(0.0f, 0.0f, rotationGesture.RotationDegreesDelta);
            }
        }
       
        
        private void Start()
        {
            FingersScript.Instance.AddGesture(rotationGesture);
            rotationGesture.StateUpdated += RotationGestureUpdated;
            rotationGesture.PlatformSpecificView = RotateIcon;

            // if you wanted to rotate the earth from the center of the earth rather than the button, you could do this:
            //Vector3 screenPos = Camera.main.WorldToScreenPoint(Earth.transform.position);
            //rotationGesture.AnglePointOverrideX = screenPos.x;
            //rotationGesture.AnglePointOverrideY = screenPos.y;
        }
    }
}