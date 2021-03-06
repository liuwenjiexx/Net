﻿using System;


namespace Net.Messages
{

    public class Message<T> : MessageBase
    {
        public Message()
        {
        }

        public Message(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }
    }

}
