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

        public char Qualifier {get;}

        public SlotAttribute()
        {
            Name = string.Empty;
            Position = null;
        }

        public SlotAttribute(string name, char qualifier = ' ')
        {
            Name = name;
            Position = null;
            Qualifier = qualifier;
        }

        public SlotAttribute(long position, char qualifier = ' ')
        {
            Name = string.Empty;
            Position = position;
            Qualifier = qualifier;
        }
    }
}