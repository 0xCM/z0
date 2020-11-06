//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Struct)]
    public class EventAttribute : Attribute
    {
        public EventAttribute()
        {
            EventName = "";
        }

        public EventAttribute(string name)
        {
            EventName = name;
        }

        public string EventName {get;}
    }
}