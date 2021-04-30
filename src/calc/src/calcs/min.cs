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
    using static ApiClassKind;

    partial struct Calcs
    {
        [MethodImpl(Inline), Factory(Min), Closures(Closure)]
        public static Min<T> min<T>()
            where T : unmanaged
                => default(Min<T>);

        [MethodImpl(Inline), Factory(Min), Closures(Closure)]
        public static VMin128<T> vmin<T>(W128 w, T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline), Factory(Min), Closures(Closure)]
        public static VMin256<T> vmin<T>(W256 w, T t = default)
            where T : unmanaged
                => default;


        [MethodImpl(Inline), Factory(Min), Closures(Closure)]
        public static Min128<T> min<T>(W128 w)
            where T : unmanaged
                => default(Min128<T>);

        [MethodImpl(Inline), Factory(Min), Closures(Closure)]
        public static Min256<T> min<T>(W256 w)
            where T : unmanaged
                => default(Min256<T>);

        /// <summary>
        /// Finds a numeric cell of minimal value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Min, Closures(AllNumeric)]
        public static T min<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var count = src.Length;
            if(count == 0)
                return default;

            ref readonly var a = ref first(src);
            var result = a;
            for(var i = 1; i<count; i++)
            {
                ref readonly var test = ref skip(a, i);
                if(gmath.lt(test, result))
                    result = test;
            }

            return result;
        }

        [MethodImpl(Inline), Min, Closures(Closure)]
        public static ref readonly SpanBlock128<T> min<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged
                => ref min<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Min, Closures(Closure)]
        public static ref readonly SpanBlock256<T> min<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged
                => ref min<T>(w256).Invoke(a, b, dst);
    }
}