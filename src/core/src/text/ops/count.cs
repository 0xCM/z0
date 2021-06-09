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

    partial struct TextTools
    {
        [MethodImpl(Inline), Op]
        public static uint count(string src, params char[] matches)
        {
            var count = 0u;
            var tests = @readonly(matches);
            var input = src.ToSpan();
            var mcount = tests.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(input,i);
                for(var j=0; j<mcount; j++)
                    if(c == skip(tests,j))
                        mcount++;
            }
            return count;
        }

        [MethodImpl(Inline), Op]
        public static uint pack(ReadOnlySpan<string> src, Span<AsciCode> dst)
        {
            var count = src.Length;
            var max = dst.Length;
            var k=0u;
            for(var i=0; i<count; i++)
            {
                var s = span(skip(src,i));
                var length = s.Length;

                for(var j=0; j<length && k<max; j++)
                    seek(dst,k++) = (AsciCode)skip(s,j);
                if(k < max)
                    seek(dst,k++) = AsciCode.Null;
            }
            return k;
        }

        [MethodImpl(Inline), Op]
        public static uint charcount(ReadOnlySpan<string> src)
        {
            var counter = 0u;
            var count = src.Length;
            for(var i=0; i<counter; i++)
                counter += (uint)skip(src,i).Length;
            return counter;
        }
    }
}