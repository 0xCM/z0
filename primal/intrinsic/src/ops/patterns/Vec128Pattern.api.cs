//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Linq;

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    using static As;
    using static VecParts128x8u;

    /// <summary>
    /// Defines an api for accessing/specifying 128-bit pattern vectors
    /// </summary>
    public static class Vec128Pattern
    {
        /// <summary>
        /// Returns an immutable reference to a vector where each component is assigned the numeric value 1
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        internal static Vector128<T> units<T>()
            where T : unmanaged
        {            
            var n = n128;
            var data = BlockedSpan.AllocBlock(n, gmath.one<T>());
            return ginx.vload(n, in data.Head);
        }

        [MethodImpl(Inline)]
        internal static Vector128<T> increments<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return inc_128u<T>();
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return inc_128i<T>();
            else 
                throw unsupported<T>();
        }            

        [MethodImpl(Inline)]
        static Vector128<T> inc_128u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(inc_128x8u());
            else if(typeof(T) == typeof(ushort))
                return generic<T>(inc_128x16u());
            else if(typeof(T) == typeof(uint))
                return generic<T>(inc_128x32u());
            else if(typeof(T) == typeof(ulong))
                return generic<T>(inc_128x64u());
            else
                throw unsupported<T>();
        }            

        [MethodImpl(Inline)]
        static Vector128<T> inc_128i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(inc_128x8i());
            else if(typeof(T) == typeof(short))
                return generic<T>(inc_128x16i());
            else if(typeof(T) == typeof(int))
                return generic<T>(inc_128x32i());
            else if(typeof(T) == typeof(long))
                return generic<T>(inc_128x64i());
            else
                throw unsupported<T>();
        }            

        /// <summary>
        /// Creates a vector where each the component value at index i + 1, except the first, is obtained by 
        /// incrementing the value of the component at index i
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vector128<T> increments<T>(T first = default, params Swap[] swaps)
            where T : unmanaged  
        {
            var n = Vec128<T>.Length;
            var src = Span128.Load(range(first, gmath.add(first, convert<T>(n - 1))).ToArray().AsSpan());
            var swapped = src.Swap(swaps);
            return ginx.vload(n128, in head(swapped));
        }

        /// <summary>
        /// Creates a vector where each the component value at index i + 1, except the first, is obtained by 
        /// decrementing the value of the component at index i
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="swaps">Transpositions applied to the decreasing sequence prior to vector creation</param>
        /// <typeparam name="T">The primal component type</typeparam>        
        public static Vector128<T> decrements<T>(T first, params Swap[] swaps)
            where T : unmanaged  
        {
            var n = Vector128<T>.Count;
            var dst = Span128.AllocBlock<T>();
            var val = first;
            for(var i=0; i<n; i++)
            {
                dst[i] = val;
                gmath.dec(ref val);
            }
            
            var swapped = dst.Swap(swaps);
            return ginx.vload(n128, in head(swapped));
        }
        
        [MethodImpl(Inline)]
        public static Vector128<T> ones<T>()
            where T : unmanaged
                => ginx.veq(default(Vector128<T>), default(Vector128<T>));

        [MethodImpl(Inline)]
        static Vector128<sbyte> inc_128x8i(N128 n = default)
            => v8i(ginx.vload(n, in head(Vec128PatternData.Inc8u)));

        [MethodImpl(Inline)]
        static Vector128<byte> inc_128x8u(N128 n = default)
            => ginx.vload(n, in head(Vec128PatternData.Inc8u));

        [MethodImpl(Inline)]
        static Vector128<short> inc_128x16i(N128 n = default)
            => v16i(ginx.vload(n, in head(Vec128PatternData.Inc16u)));

        [MethodImpl(Inline)]
        static Vector128<ushort> inc_128x16u(N128 n = default)
            => v16u(ginx.vload(n, in head(Vec128PatternData.Inc16u)));

        [MethodImpl(Inline)]
        static Vector128<int> inc_128x32i(N128 n = default)
            => v32i(ginx.vload(n, in head(Vec128PatternData.Inc32u)));

        [MethodImpl(Inline)]
        static Vector128<uint> inc_128x32u(N128 n = default)
            => v32u(ginx.vload(n, in head(Vec128PatternData.Inc32u)));

        [MethodImpl(Inline)]
        static Vector128<long> inc_128x64i(N128 n = default)
            => v64i(ginx.vload(n, in head(Vec128PatternData.Inc64u)));

        [MethodImpl(Inline)]
        static Vector128<ulong> inc_128x64u(N128 n = default)
            => v64u(ginx.vload(n, in head(Vec128PatternData.Inc64u)));


    }
}