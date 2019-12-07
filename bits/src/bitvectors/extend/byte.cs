//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitVectorX
    {
        /// <summary>
        /// Extracts an index-identified byte from the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The 0-based and byte-relative index of the desired byte</param>
        /// <typeparam name="N">The vector length type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static byte Byte<N,T>(this BitVector<N,T> src, int index)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => Unsafe.Add(ref Unsafe.As<T,byte>(ref src.data), index);
    }
}