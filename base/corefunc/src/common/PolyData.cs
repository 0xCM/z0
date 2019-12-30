//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public static class PolyData
    {

        /// <summary>
        /// Copies a specified number of source values to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="srcCount">The number of source values to copy</param>
        /// <param name="dst">The target reference</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static uint copy<S,T>(in S src, ref T dst, int srcCount, int dstOffset = 0)
            where S: unmanaged
            where T :unmanaged
        {
            ref var input = ref Unsafe.As<S,byte>(ref Unsafe.AsRef(in src));
            ref var target = ref Unsafe.As<T,byte>(ref Unsafe.Add(ref dst, dstOffset));
            var bytecount =  (uint)(srcCount*Unsafe.SizeOf<S>());
            Unsafe.CopyBlock(ref target, ref input, bytecount);
            return bytecount;
        }
    }
}