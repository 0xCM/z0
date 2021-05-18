//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    partial struct Index
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool equals<T>(ReadOnlySpan<T> src, ReadOnlySpan<T> dst)
            where T : IEquatable<T>
        {
            var count = src.Length;
            if(count != dst.Length)
                return false;

            if(count == 0)
                return true;

            ref readonly var a = ref first(src);
            ref readonly var b = ref first(dst);
            for(var i=0; i<count; i++)
                if(!skip(a,i).Equals(skip(b,i)))
                    return false;

            return true;
        }

        [MethodImpl(Inline)]
        public static bool equals<T,C>(ReadOnlySpan<T> src, ReadOnlySpan<T> dst, C comparer)
            where C : IEqualityComparer<T>
        {
            var count = src.Length;
            if(count != dst.Length)
                return false;

            if(count == 0)
                return true;

            ref readonly var a = ref first(src);
            ref readonly var b = ref first(dst);
            for(var i=0; i<count; i++)
                if(!comparer.Equals(skip(a,i),skip(b,i)))
                    return false;

            return true;
        }
    }
}