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

    partial struct Seq
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : IEquatable<T>
        {
            var count = lhs.Length;
            if(count != rhs.Length)
                return false;

            ref readonly var a = ref first(lhs);
            ref readonly var b = ref first(rhs);
            for(var i=0u; i<count; i++)
                if(!skip(a, i).Equals(skip(b, i)))
                    return false;
            return true;
        }
    }
}