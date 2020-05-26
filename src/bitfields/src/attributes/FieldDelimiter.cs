//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [AttributeUsage(AttributeTargets.Enum)]
    public class FieldDelimiterAttribute : Attribute
    {
        public FieldDelimiterAttribute()
        {

        }

        public FieldDelimiterAttribute(byte first, byte last)
        {
            FirstIndex = first;
            LastIndex = last;
        }

        /// <summary>
        /// The left bitfield index
        /// </summary>
        public byte FirstIndex {get;}

        /// <summary>
        /// The right bitfield index
        /// </summary>
        public byte LastIndex {get;}
    }
}