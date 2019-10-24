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

    /// <summary>
    /// Reifies and provides storage for common 128-bit vector patterns
    /// </summary>
    public readonly struct Vec128Pattern<T> 
        where T : unmanaged
    {
        static readonly int Length = Vec128<T>.Length;


        /// <summary>
        /// Creates a vector with incrementing components
        /// v[0] = first and v[i+1] = v[i] + 1 for i=1...N-1
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Increments(T first = default, params Swap[] swaps)
        {
            var src = Span128.Load(range(first, gmath.add(first, convert<T>(Length - 1))).ToArray().AsSpan());
            return Vec128.Load(src.Swap(swaps));
        }

        /// <summary>
        /// Creates a vector with decrementing components
        /// v[0] = last and v[i-1] = v[i] - 1 for i=1...N-1
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <param name="swaps">Transpositions applied to decrements prior to vector creation</param>
        /// <typeparam name="T">The primal component type</typeparam>        
        public static Vec128<T> Decrements(T first = default, params Swap[] swaps)
        {
            var n = Length;
            var dst = Span128.AllocBlock<T>();
            var val = first;
            for(var i=0; i<n; i++)
            {
                dst[i] = val;
                gmath.dec(ref val);
            }

            return Vec128.Load(dst.Swap(swaps));
        }

        public static Vector128<T> Units()
        {
            var n = Length;
            var dst = Span128.Alloc<T>(n);
            var one = gmath.one<T>();
            for(var i=0; i<n; i++)
                dst[i] = one;                
            ginx.vloadu(in dst[0], out Vector128<T> u);
            return u;
        }

        static Vec128<T> CalcFpSignMask()
        {
            if(typeof(T) == typeof(float))
                return CalcFpSignMask32().As<T>();
            else if(typeof(T) == typeof(double))
                return CalcFpSignMask64().As<T>();
            else 
                return Vec128<T>.Zero;
        }

        static Vec128<double> CalcFpSignMask64()
            => Vec128.Fill(-0.0);

        static Vec128<float> CalcFpSignMask32()
            => Vec128.Fill(-0.0f);
    }
}

