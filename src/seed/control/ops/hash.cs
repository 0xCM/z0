//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Control
    {
        /// <summary>
        /// Computes the FNV-1a hash of the source sequence
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="src">The data source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int hash(ReadOnlySpan<byte> src)
        {
            int hashCode = FnvOffsetBias;
            for (int i = 0; i < src.Length; i++)
                hashCode = unchecked((hashCode ^ skip(src,i)) * FnvPrime);
            return hashCode;
        }

        /// <summary>
        /// Creates a combined hash from a pair of integers
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int hash(int x, int y)
            => unchecked((y * (int)K) + x);

        /// <summary>
        /// Creates a combined hash from a pair of unsigned integers
        /// </summary>
        /// <param name="x">The left source</param>
        /// <param name="y">The right source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        [MethodImpl(Inline), Op]
        public static int hash(uint x, uint y)
            => unchecked(((int)y * (int)K) + (int)x);

        const uint K = 0xA5555529;
        
        const int FnvOffsetBias = unchecked((int)2166136261);

        const int FnvPrime = 16777619;
    }
}