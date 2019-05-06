using System;
using System.Collections.Generic;
using System.Text;

namespace TheBreakfast
{
    interface CookListener
    {
        void onPreparation();
        void onCooking(String message);
        void onReady(String message);
    }
}
