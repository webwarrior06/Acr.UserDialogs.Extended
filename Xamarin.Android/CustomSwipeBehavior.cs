using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Util;
using AndroidX.CoordinatorLayout.Widget;
using Google.Android.Material.Behavior;
using Java.Lang;
using Object = Java.Lang.Object;

namespace Xamarin.Android
{
    public class CustomSwipeBehavior : SwipeDismissBehavior
    {
        private string TAG = "CustomSwipeBehavior";

        public static int IDLE = 0;
        public static int LEFT = 1;
        public static int RIGHT = 2;

        float x1, x2;
        float minimum = 0;

        //1 left, 2 = right
        int direction = 1;

        bool acceptswipe = true;

 
        public override bool OnInterceptTouchEvent(CoordinatorLayout parent, Object child, MotionEvent e)
        {
            setDirection(e);
            return base.OnInterceptTouchEvent(parent, child, e);
        }

        public override bool OnTouchEvent(CoordinatorLayout parent, Object child, MotionEvent e)
        {
            setDirection(e);
            return base.OnTouchEvent(parent, child, e);
        }

        public override bool CanSwipeDismissView(View view)
        {
            if (acceptswipe)
            {
                Log.Debug(TAG, "onTouchEvent: 1");
                return base.CanSwipeDismissView(view);
            }
            else
            {
                Log.Debug(TAG, "onTouchEvent: 2");
                return false;
            }
        }

        public override void SetSensitivity(float sensitivity)
        {
            base.SetSensitivity(sensitivity);
            acceptswipe = sensitivity != 0.0f;
        }


        private void setDirection(MotionEvent e)
        {
            //Log.d(TAG, "setDirection: motion event =  " + event);

            switch (e.Action)
            {
                case MotionEventActions.Down:
                    if (x1 == 0)
                    {
                        x1 = e.GetX();
                        //Log.d(TAG, "calculate: x1: " + String.valueOf(x1));
                    }

                    break;
                case MotionEventActions.Move:
                    if (x1 == 0)
                    {
                        x1 = e.GetX();
                        //Log.d(TAG, "calculate: x1: " + String.valueOf(x1));
                    }

                    break;

                case MotionEventActions.Up:
                    x2 = e.GetX();
                    //Log.d(TAG, "calculate: x2 : " + String.valueOf(x2));
                    Calculate(x1, x2);
                    break;
            }
        }

        private void Calculate(float x1, float x2)
        {
            var delta = x1 - x2;

            //Log.d(TAG, "calculate: x1: " + String.valueOf(x1) + "  x2: " + String.valueOf(x2) + "  delta: " + String.valueOf(delta));

            if (delta > minimum)
            {
                direction = LEFT;
            }
            else if (delta < -minimum)
            {
                direction = RIGHT;
            }
            else
            {
                direction = IDLE;
            }

            x1 = 0;
            x2 = 0;

            //Log.d(TAG, "calculate: " + direction);
        }


        public int GetDirection()
        {
            int temp = direction;
            direction = IDLE;

            return temp;
        }
    }
}
