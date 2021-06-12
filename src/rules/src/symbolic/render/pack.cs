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

    partial struct SymbolicRender
    {
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
    }
}