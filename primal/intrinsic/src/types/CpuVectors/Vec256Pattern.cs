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
    /// Reifies and provides storage for common 256-bit vector patterns
    /// </summary>
    public readonly struct Vec256Pattern<T> 
        where T : unmanaged
    {
        static readonly int Length = Vec256<T>.Length;

        static readonly Vec256<T> Zero = Vec256<T>.Zero;

        /// <summary>
        /// A vector with all bits turned on
        /// </summary>
        public static readonly Vec256<T> AllOnes = ginx.cmpeq(Zero, Zero);

        /// <summary>
        /// A vector where each component is assigned the numeric value 1
        /// </summary>
        public static readonly Vec256<T> Units = CalcUnits();

        public static Vec256<T> Increasing 
            => Increments(zero<T>());

        public static readonly Vec256<T> Decreasing = Decrements(convert<T>(Length - 1));
        

        public static readonly Vec256<T> ClearAlt = ClearAlternating();

        public static readonly Vec256<T> FpSignMask = CalcFpSignMask();

        /// <summary>
        /// Creates a vector with incrementing components
        /// v[0] = first and v[i+1] = v[i] + 1 for i=1...N-1
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec256<T> Increments(T first = default, params Swap[] swaps)
        {
            var src = Span256.Load(range(first, gmath.add(first, convert<T>(Length - 1))).ToArray().AsSpan());
            return Vec256.Load(src.Swap(swaps));
        }

        /// <summary>
        /// Creates a vector with decrementing components
        /// v[0] = last and v[i-1] = v[i] - 1 for i=1...N-1
        /// </summary>
        /// <param name="last">The value of the first component</param>
        /// <param name="swaps">Transpositions applied to decrements prior to vector creation</param>
        /// <typeparam name="T">The primal component type</typeparam>        
        public static Vec256<T> Decrements(T last = default, params Swap[] swaps)
        {
            var n = Length;
            var dst = Span256.Alloc<T>(n);
            var val = last;
            for(var i=0; i<n; i++)
            {
                dst[i] = val;
                gmath.dec(ref val);
            }

            return Vec256.Load(dst.Swap(swaps));
        }

        static Vec256<T> CalcUnits()
        {
            var n = Length;
            var dst = Span256.Alloc<T>(n);
            var one = gmath.one<T>();
            for(var i=0; i<n; i++)
                dst[i] = one;
            return Vec256.Load(dst);
        }


        static Vec256<T> CalcFpSignMask()
        {
            if(typeof(T) == typeof(float))
                return CalcFpSignMask32().As<T>();
            else if(typeof(T) == typeof(double))
                return CalcFpSignMask64().As<T>();
            else 
                return Zero;
        }

        static Vec256<T> ClearAlternating()
        {
            var mask = Span256.Alloc<T>(1);
            var chop = PrimalInfo.Get<T>().MaxVal;
            
            //For the first 128-bit lane
            var half = mask.Length/2;
            for(byte i=0; i< half; i++)
            {
                if(i % 2 != 0)
                    mask[i] = chop;
                else
                    mask[i] = convert<byte,T>(i);
            }

            //For the second 128-bit lane
            for(byte i=0; i< half; i++)
            {
                if(i % 2 != 0)
                    mask[i + half] = chop;
                else
                    mask[i + half] = convert<byte,T>(i);
            }

            return Vec256.Load(mask);
        }
            
    
        static Vec256<double> CalcFpSignMask64()
            => Vec256.Fill(-0.0);

        static Vec256<float> CalcFpSignMask32()
            => Vec256.Fill(-0.0f);
    }

}