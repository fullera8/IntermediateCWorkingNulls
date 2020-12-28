using System;
using System.Collections.Generic;
using System.Text;

namespace CS8NullBasics
{
    class Message
    {
        //No params, set all to default
        public Message()
        {
            From = "";
            Text = "";
        }
        //Provided params, set value or default if null
        public Message(string? From, string? Text)
        {
            this.From = string.IsNullOrEmpty(From) ? "[no from]" : From;
            this.Text = string.IsNullOrEmpty(Text) ? "[no text]" : Text;
        }

        public string From { get; set; }
        public string Text { get; set; }
        public string ToUpperFrom() => From.ToUpperInvariant(); 
    }
}
