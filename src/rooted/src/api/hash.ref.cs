//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Roots
    {            
        const uint K = 0xA5555529;
        
        const uint FnvOffsetBias = 2166136261;

        const uint FnvPrime = 16777619;

        /// <summary>
        /// Computes the FNV-1a hash of the source sequence
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="src">The data source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        static uint hash_ref(ReadOnlySpan<byte> src)
        {
            var hashCode = FnvOffsetBias;
            for (int i = 0; i < src.Length; i++)
                hashCode = (hashCode ^ skip(src,i)) * FnvPrime;
            return hashCode;
        }        
    }
}