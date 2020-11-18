//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    /// <summary>
    /// Defines the range of a layout segment
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct LayoutRange
    {
        /// <summary>
        /// The postion of the least-significant bit
        /// </summary>
        public readonly ulong Left;

        /// <summary>
        /// The postion of the most-significant bit
        /// </summary>
        public readonly ulong Right;

        [MethodImpl(Inline)]
        public LayoutRange(ulong left, ulong right)
        {
            Left = left;
            Right = right;
        }

        [MethodImpl(Inline)]
        public static implicit operator LayoutRange((ulong lsb, ulong msb) src)
            => new LayoutRange(src.lsb, src.msb);
    }
}