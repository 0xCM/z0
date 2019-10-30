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


        public static Vector256<T> Increasing 
        {
            [MethodImpl(Inline)]
            get => Increments();
        }

        public static Vector256<T> Decreasing 
            => Decrements(convert<T>(Length - 1));
        
        public static Vector256<T> ClearAlt() 
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

            return mask.LoadVector();
        }

        public static Vector256<T> FpSignMask 
            => CalcFpSignMask();

        /// <summary>
        /// Creates a vector with incrementing components
        /// v[0] = first and v[i+1] = v[i] + 1 for i=1...N-1
        /// </summary>
        /// <param name="first">The value of the first component</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> Increments(T first = default, params Swap[] swaps)
        {
            var src = Span256.Load(range(first, gmath.add(first, convert<T>(Length - 1))).ToArray().AsSpan());
            return src.Swap(swaps).LoadVector();
        }

        /// <summary>
        /// Creates a vector with decrementing components
        /// v[0] = last and v[i-1] = v[i] - 1 for i=1...N-1
        /// </summary>
        /// <param name="last">The value of the first component</param>
        /// <param name="swaps">Transpositions applied to decrements prior to vector creation</param>
        /// <typeparam name="T">The primal component type</typeparam>        
        public static Vector256<T> Decrements(T last = default, params Swap[] swaps)
        {
            var n = Length;
            var dst = Span256.Alloc<T>(n);
            var val = last;
            for(var i=0; i<n; i++)
            {
                dst[i] = val;
                gmath.dec(ref val);
            }

            return dst.Swap(swaps).LoadVector();
        }

        static Vector256<T> CalcFpSignMask()
        {
            if(typeof(T) == typeof(float))
                return As.generic<T>(CalcFpSignMask32());
            else if(typeof(T) == typeof(double))
                return As.generic<T>(CalcFpSignMask64());
            else 
                return default;
        }

        static Vector256<T> ClearAlternating()
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

            return mask.LoadVector();
        }
            
        static Vector256<double> CalcFpSignMask64()
            => dfp.vbroadcast(n256,-0.0);

        static Vector256<float> CalcFpSignMask32()
            => dfp.vbroadcast(n256,-0.0f);
    }

}