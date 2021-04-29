//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static CalcHosts;

    partial struct Calcs
    {
        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Max128<T> max<T>(W128 w)
            where T : unmanaged
                => default(Max128<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Max256<T> max<T>(W256 w)
            where T : unmanaged
                => default(Max256<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Max<T> max<T>()
            where T : unmanaged
                => default(Max<T>);

        /// <summary>
        /// Finds a numeric cell of maximal value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Max, Closures(AllNumeric)]
        public static T max<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var count = src.Length;
            if(count == 0)
                return default;

            ref readonly var a = ref first(src);
            var result = a;
            for(var i=1; i<count; i++)
            {
                ref readonly var test = ref skip(a, i);
                if(gmath.gt(test, result))
                    result = test;
            }
            return result;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock128<T> max<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref max<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly SpanBlock256<T> max<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref max<T>(w256).Invoke(a, b, dst);
    }
}