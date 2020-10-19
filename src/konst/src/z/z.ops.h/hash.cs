//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Computes the FNV-1a hash of the source sequence
        /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
        /// </summary>
        /// <param name="src">The data source</param>
        /// <remarks>Adapted from the .Net core type System.Reflection.Internal.Hash</remarks>
        const uint K = 0xA5555529;

        const uint FnvOffsetBias = 2166136261;

        const uint FnvPrime = 16777619;

        [MethodImpl(Inline), Op]
        public static uint hash(Type src)
            => (uint)src.MetadataToken;

        /// <summary>
        /// Creates a 64-bit hash code predicated on two types
        /// </summary>
        /// <typeparam name="S">The first type</typeparam>
        /// <typeparam name="T">The second type</typeparam>
        [MethodImpl(Inline)]
        public static ulong hash(Type t1, Type t2)
            => (ulong)hash(t1) | (ulong)hash(t2) << 32;

        /// <summary>
        /// Creates a 64-bit hash code predicated on three types
        /// </summary>
        /// <typeparam name="S">The first type</typeparam>
        /// <typeparam name="T">The second type</typeparam>
        [MethodImpl(Inline)]
        public static ulong hash(Type t1, Type t2, Type t3)
            => hash(t1,t2) ^ hash(t1, t3);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint hash<T>(Vector128<T> src)
            where T : unmanaged
        {
            var v = v64u(src);
            return hash(vcell(v,0), vcell(v,1));
        }
    }
}