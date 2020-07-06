//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class RootLegacy
    {
        [MethodImpl(Inline), Op]
        public static void refs(ReadOnlySpan<string> src, Span<StringRef> dst)
        {
            for(var i=0; i<src.Length; i++)
                seek(dst,i) = @ref(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static StringRef[] refs(ReadOnlySpan<string> src)
        {
            var dst = sys.alloc<StringRef>(src.Length);
            refs(src,dst);
            return dst;
        }
    }
}