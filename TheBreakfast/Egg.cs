﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TheBreakfast
{
    class Egg
    {
        private CookListener listener;
        public Egg(CookListener listener)
        {
            this.listener = listener;
        }

        public void startCooking()
        {

            this.listener.onPreparation();
            ThreadStart cooking = new ThreadStart(cookingProcess);
            Thread childThread = new Thread(cooking);
            childThread.Start();
        }

        private void cookingProcess()
        {
            // do some work, like counting to 10 on other threads
            for (int counter = 10; counter >= 0; counter--)
            {
                Thread.Sleep(1000);
                this.listener.onCooking("cooking. wait for ..." + counter + " second.");
            }

            this.listener.onReady("Done. Egg ready to eat");
        }
    }
}
