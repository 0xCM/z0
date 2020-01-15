//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {
        [MethodImpl(Inline), Op]
        public static T sum<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            checked
            {
                var count = src.Length;
                ref readonly var input = ref head(src);
                var result = default(T);

                for(var i=0; i< src.Length; i++)
                    result = gmath.add(result, skip(input,i));
                return result;
            }
        }

        [MethodImpl(Inline), Op]
        public static T sum<T>(Span<T> src)
            where T : unmanaged
                => sum(src.ReadOnly());

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal scalar type</typeparam>
        [MethodImpl(Inline), Op]
        public static T dot<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var count = lhs.Length;
            ref readonly var lSrc = ref head(lhs);
            ref readonly var rSrc = ref head(rhs);

            var dst = default(T);
            for(var i = 0; i< count; i++)
                dst = gmath.fma(skip(lSrc, i), skip(rSrc,i), dst);
            return dst;                
        }

        [MethodImpl(Inline), Op]
        public static T min<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var count = src.Length;
            if(count == 0)
                return default;
            
            ref readonly var input = ref head(src);
            var result = input;

            for(var i = 1; i< count; i++)
            {
                ref readonly var test = ref skip(in input, i);
                if(gmath.lt(test, result))
                    result = test;
            }

            return result;
        }

        [MethodImpl(Inline), Op]
        public static T max<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var count = src.Length;
            if(count == 0)
                return default;
            
            ref readonly var input = ref head(src);
            var result = input;

            for(var i = 1; i< count; i++)
            {
                ref readonly var test = ref skip(in input, i);
                if(gmath.gt(test, result))
                    result = test;
            }

            return result;
        }

        [MethodImpl(Inline), Op]
        public static T max<T>(Span<T> src)
            where T : unmanaged
                => max(src.ReadOnly());

    }
}