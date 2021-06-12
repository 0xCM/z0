//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct SymbolicQuery
    {
        [MethodImpl(Inline), Op]
        public static uint count(ReadOnlySpan<char> src, params char[] matches)
        {
            var count = 0u;
            var tests = @readonly(matches);
            var mcount = tests.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                for(var j=0; j<mcount; j++)
                    if(c == skip(tests,j))
                        mcount++;
            }
            return count;
        }
    }
}