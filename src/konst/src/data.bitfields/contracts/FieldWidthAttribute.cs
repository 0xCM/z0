//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Specifies the effective bit-width of a bitfield segment
    /// </summary>
    public class FieldWidthAttribute : Attribute
    {
        public FieldWidthAttribute(byte width)
        {
            Width = width;
        }

        public byte Width {get;}
    }
}