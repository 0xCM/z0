//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class EventAttribute : Attribute
    {
        public EventAttribute()
        {
        }

        public EventAttribute(string name)
        {
            EventName = name;
        }

        public string EventName {get;}        
    }
}