using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Events
{
    class VideoEncoder
    {
        /*  Steps to handle events
         1. Define delegate
         2. Define an event based on that delegate
         3. Raise the event
         */

        /* Old way of defining delegate and Event
            * Define delegate
             public delegate void VideoEncodedEventHandler(object source, EventArgs args);

            * Define an event based on above delegate
            public event VideoEncodedEventHandler VideoEncoded;
        */

        //Good way of defining delegate which acts as bridge between publisher and subscriber
        public event EventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video....");
            Thread.Sleep(3000);

            //Raise the event
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
