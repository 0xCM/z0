//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static TypeNats;

    partial class XTend
    {
        /// <summary>
        /// Clones a natural span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static NatSpan<N,T> Replicate<N,T>(this in NatSpan<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            Span<T> dst = new T[value<N>()];
            src.CopyTo(dst);
            return new NatSpan<N,T>(dst);
        }
    }
}