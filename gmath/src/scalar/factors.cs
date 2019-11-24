//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;        

    partial class gmath
    {
        /// <summary>
        /// Inefficiently factors a primal value
        /// </summary>
        /// <param name="k">The value to factor</param>
        public static Span<Pair<T>> factor<T>(T k, int? maxcount = null)
            where T :unmanaged
        {
            Span<Pair<T>> pairs = new Pair<T>[maxcount ?? 100];          
            var count = factor(k,pairs,0);  
            return pairs.Slice(0,count);                 
        }

        /// <summary>
        /// Inefficiently factors a primal value
        /// </summary>
        /// <param name="k">The value to factor</param>
        [MethodImpl(Inline)]
        static int factor<T>(T k, Span<Pair<T>> dst, int offset)
            where T : unmanaged
        {
            var count = 0;
            var zero = zero<T>();
            var i = one<T>();
            while(lteq(i,k))
            {
                var m = mod(k,i);
                if(eq(m,zero))
                    dst[offset + count++] = (i, div(k,i));
                i = inc(i);
            }
            
            return count;            
        }

        static Span<Pair<uint>> factors(uint k)
        {
            Span<Pair<uint>> pairs = new Pair<uint>[(int)k/2];          
            var count = factors(k,pairs,0);  
            return pairs.Slice(0,count);                 
        }

        [MethodImpl(Inline)]
        static int factors(uint k, Span<Pair<uint>> dst, int offset)
        {
            var count = 0;
            for(var i=1u; i<=k; i++)
                if(k % i == 0)
                    dst[offset + count++] = (i, k/i);
            return count;            
        }


    }
}