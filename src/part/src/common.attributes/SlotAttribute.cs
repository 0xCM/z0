//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies and optionally describes a slot, characterized by postion, name, both or neither
    /// </summary>
    public class SlotAttribute : Attribute
    {
        public string Name {get;}

        public long? Position {get;}

        public SlotAttribute()
        {
            Name = string.Empty;
            Position = null;
        }

        public SlotAttribute(string name)
        {
            Name = name;
            Position = null;
        }

        public SlotAttribute(long position)
        {
            Name = string.Empty;
            Position = position;
        }

        public SlotAttribute(string name, long position)
        {
            Name = name;
            Position = position;
        }
    }
}