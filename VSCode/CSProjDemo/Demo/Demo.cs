﻿using Bridge.Html5;

namespace Demo
{
    public class DemoClass
    {
        [Ready]
        public static void main()
        {
            Console.Log("Demo. Logged on console.");

            var spanEl = new SpanElement()
            {
                InnerHTML = "If you can read this line, then bridge is working!"
            };
            Document.Body.AppendChild(spanEl);
        }
    }
}