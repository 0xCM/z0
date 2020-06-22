//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Identifies a bitfield specification
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum)]
    public class BitFieldAttribute : Attribute
    {
        public BitFieldAttribute()
        {
            
        }

        /// <summary>
        /// Specifies the bitfield section [0..right]
        /// </summary>
        /// <param name="right">The inclusive right bitfield index</param>
        public BitFieldAttribute(byte right)
        {
            LeftIndex = 0;
            RightIndex = right;
        }

        /// <summary>
        /// Specifies the bitfield section [left..right]
        /// </summary>
        /// <param name="left">The inclusive left bitfield index</param>
        /// <param name="right">The inclusive right bitfield index</param>
        public BitFieldAttribute(byte left, byte right)
        {
            LeftIndex = left;
            RightIndex = right;
        }

        /// <summary>
        /// The left bitfield index
        /// </summary>
        public byte LeftIndex {get;}

        /// <summary>
        /// The right bitfield index
        /// </summary>
        public byte RightIndex {get;}
    }
}