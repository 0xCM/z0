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

        public EventAttribute(bool descriptor)
        {
            IsDescriptor = descriptor;
        }

        public bool IsDescriptor {get;}        
    }
}