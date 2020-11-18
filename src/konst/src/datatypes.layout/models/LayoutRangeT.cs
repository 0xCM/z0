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
    public readonly struct LayoutRange<T>
        where T : unmanaged
    {
        /// <summary>
        /// The postion of the least-significant bit
        /// </summary>
        public T Left {get;}

        /// <summary>
        /// The postion of the most-significant bit
        /// </summary>
        public T Right {get;}

        [MethodImpl(Inline)]
        public LayoutRange(T left, T right)
        {
            Left = left;
            Right = right;
        }

        [MethodImpl(Inline)]
        public static implicit operator LayoutRange<T>((T lsb, T msb) src)
            => new LayoutRange<T>(src.lsb, src.msb);

        [MethodImpl(Inline)]
        public static implicit operator LayoutRange<T>(Pair<T> src)
            => new LayoutRange<T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator LayoutRange<T>(ClosedInterval<T> src)
            => new LayoutRange<T>(src.Min, src.Max);
    }
}