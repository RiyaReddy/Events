using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine(" Message Service: Sending a text message");
        }
    }
}
