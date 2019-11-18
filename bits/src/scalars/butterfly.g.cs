//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static T butterfly<T>(N1 n, T x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.butterfly(n,uint8(x)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.butterfly(n,uint16(x)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.butterfly(n,uint32(x)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.butterfly(n,uint64(x)));
            else            
                throw unsupported<T>();
        }

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static T butterfly<T>(N2 n, T x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Bits.butterfly(n,uint8(x)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.butterfly(n,uint16(x)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.butterfly(n,uint32(x)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.butterfly(n,uint64(x)));
            else            
                throw unsupported<T>();
        }

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 4-bit segments of each 16-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> [0 1 2 3 | 4 5 6 7 | 8 9 A B | C D E F] -> [0 2 1 3 | 4 6 5 7 | 8 A 9 B | C E D F]</remarks>
        [MethodImpl(Inline)]
        public static T butterfly<T>(N4 n, T x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return x;
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.butterfly(n,uint16(x)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.butterfly(n,uint32(x)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.butterfly(n,uint64(x)));
            else            
                throw unsupported<T>();
        }

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 8-bit segments of each 32-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> [0 1 2 3 | 4 5 6 7] -> [0 2 1 3 | 4 6 5 7]</remarks>
        [MethodImpl(Inline)]
        public static T butterfly<T>(N8 n, T x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(ushort))
                return x;
            else if(typeof(T) == typeof(uint))
                return generic<T>(Bits.butterfly(n,uint32(x)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.butterfly(n,uint64(x)));
            else            
                throw unsupported<T>();
        }

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior 16-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static T butterfly<T>(N16 n, T x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint))
                return x;
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.butterfly(n,uint64(x)));
            else            
                throw unsupported<T>();
        }
    }
}