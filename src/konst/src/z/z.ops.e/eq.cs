//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static bool eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : IEquatable<T>
        {
            var count = lhs.Length;
            if(count != rhs.Length)
                return false;

            ref readonly var a = ref z.first(lhs);
            ref readonly var b = ref z.first(rhs);

            for(var i=0u; i<count; i++)
                if(!skip(a, i).Equals(skip(b, i)))
                    return false;
            return true;
        }
    }
}