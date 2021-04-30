//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CalcHosts;
    using static memory;
    using static SFx;
    using static ApiClassKind;

    partial struct Calcs
    {
       [MethodImpl(Inline), Sum, Closures(Integers)]
        public static T sum<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            checked
            {
                var count = src.Length;
                ref readonly var input = ref first(src);
                var result = default(T);

                for(var i=0; i<src.Length; i++)
                    result = gmath.add(result, skip(input,i));
                return result;
            }
        }

        [MethodImpl(Inline)]
        public static T sum<T>(Span<T> src)
            where T : unmanaged
                => sum(src.ReadOnly());
    }
}