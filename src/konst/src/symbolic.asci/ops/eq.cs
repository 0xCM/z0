//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static bool eq(ReadOnlySpan<char> x, ReadOnlySpan<AsciCharCode> y)
        {
            var count = x.Length;
            if(count != y.Length)
                return false;

            for(var i=0u; i<count; i++)
                if((byte)skip(x,i) != (byte)skip(y,i))
                    return false;
            return true;
        }

        [MethodImpl(Inline), Op]
        public static bool eq(ReadOnlySpan<AsciCharCode> x, ReadOnlySpan<char> y)
            => eq(y,x);
    }
}