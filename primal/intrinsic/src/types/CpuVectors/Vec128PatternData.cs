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
    
    using static zfunc;
    using static VecParts128x8u;

    public static class Vec128PatternData
    {
        /// <summary>
        /// Defines a 128x8u vector where all components are of unit value 1
        /// </summary>
        public static ReadOnlySpan<byte> Units_8u  => new byte[16]{B,B,B,B,B,B,B,B,B,B,B,B,B,B,B,B};        

        /// <summary>
        /// Defines components {0,1,..., 14,15} for a 128x8u vector 
        /// </summary>
        public static ReadOnlySpan<byte> Inc_8u  => new byte[16]{A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 8 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotl_8x8u  => new byte[16]{P,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 16 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotl_16x8u  => new byte[16]{O,P,A,B,C,D,E,F,G,H,I,J,K,L,M,N};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 24 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotl_24x8u  => new byte[16]{N,O,P,A,B,C,D,E,F,G,H,I,J,K,L,M};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content leftward by 32 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotl_32x8u  => new byte[16]{M,N,O,P,A,B,C,D,E,F,G,H,I,J,K,L};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 8 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotr_8x8u  => new byte[16]{B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,A};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 16 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotr_16x8u  => new byte[16]{C,D,E,F,G,H,I,J,K,L,M,N,O,P,A,B};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 24 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotr_24x8u  => new byte[16]{D,E,F,G,H,I,J,K,L,M,N,O,P,A,B,C};

        /// <summary>
        /// Shuffle pattern that, when applied, rotates 128 bits of content rightward by 32 bits
        /// </summary>
        public static ReadOnlySpan<byte> Rotr_32x8u  => new byte[16]{E,F,G,H,I,J,K,L,M,N,O,P,A,B,C,D};


        public static Vec128<T> units<T>()
            where T : unmanaged
        {
            var n = Vec128<T>.Length;
            var dst = Span128.Alloc<T>(n);
            var one = gmath.one<T>();
            for(var i=0; i<n; i++)
                dst[i] = one;
            return Vec128.Load(dst);
        }

        /// <summary>
        /// Creates a vector with incrementing components
        /// v[0] = first and v[i+1] = v[i] + 1 for i=1...N-1
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec128<T> increments<T>(T first = default, params Swap[] swaps)
            where T : unmanaged
        {
            var n = Vec128<T>.Length;
            var src = Span128.Load(range(first, gmath.add(first, convert<T>(n - 1))).ToArray().AsSpan());
            return Vec128.Load(src.Swap(swaps));
        }

        /// <summary>
        /// Creates a vector with components that increase by a specified step
        /// </summary>
        /// <param name="start">The value of the first component</param>
        /// <param name="step">The distance between components</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec128<T> increasing<T>(T start, T step)
            where T : unmanaged
        {
            var n = Vec128<T>.Length;
            var current = start;
            var dst = Span256.AllocBlock<T>();
            for(var i=0; i<n; i++)
            {
                dst[i] = current;
                gmath.add(ref current, step);
            }
            return Vec128.Load(ref head(dst));

        }

    }

}