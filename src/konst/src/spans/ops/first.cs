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

    partial class Spans
    {
        /// <summary>
        /// Returns a reference to the location of the first span element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T first<N,T>(NatSpan<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => ref MemoryMarshal.GetReference<T>(src.Edit);
    }
}