//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {            
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static uint hash<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var length = src.Length;
            if(length == 0)
                return 0;

            var rolling = FnvOffsetBias;
            for(var i=0u; i<length-1; i++)
            {
                ref readonly var x = ref skip(src,i);
                ref readonly var y = ref skip(src,i + 1);
                rolling = hash(rolling, hash(x,y))*FnvPrime;
            }
            return rolling;
        }        
    }
}