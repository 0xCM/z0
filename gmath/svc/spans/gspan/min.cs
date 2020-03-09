//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;
    using static As;  

    partial class gspan
    {
        [MethodImpl(Inline)]
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

    }
}