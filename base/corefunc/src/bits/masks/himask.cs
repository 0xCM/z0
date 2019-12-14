//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class BitMask
    {           
        /// <summary>
        /// Produces a sequence of n enabled hi bits
        /// </summary>
        /// <param name="n">The number of bits to enable</param>
        [MethodImpl(Inline)]
        public static ulong himask64(int n)
            => himask<ulong>(n);

        /// <summary>
        /// Produces a sequence of N enabled hi bits
        /// </summary>
        /// <param name="n">The number of bits to enable</param>
        /// <typeparam name="N">The bit count type</typeparam>
        [MethodImpl(Inline)]
        public static ulong himask<N>(N n = default)
            where N : unmanaged, ITypeNat
                => himask<ulong>(natval(n));

        /// <summary>
        /// Produces a sequence of n enabled bits in the index range [bitsize[T] - n, bitsize[T] - 1]
        /// </summary>
        /// <param name="n">The number of bits to enable</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask type</typeparam>
        [MethodImpl(Inline)]
        public static T himask<T>(int n, T t = default)
            where T : unmanaged
        {
            var w = bitsize<T>() - n;
            return convert<T>(lomask64(n) << w);
        }

        /// <summary>
        /// Produces a sequence of n enabled hi bits
        /// </summary>
        /// <param name="n">The number of bits to enable</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T himask<N,T>(N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => convert<ulong,T>(himask(n));
    }
}