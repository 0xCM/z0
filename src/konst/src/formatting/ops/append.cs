//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;
        
    partial struct Format
    {
        [MethodImpl(Inline), Op]
        public static void append(ReadOnlySpan<char> src, StringBuilder dst)
            => dst.Append(src);

        [MethodImpl(Inline), Op]
        public static void append(ReadOnlySpan<char> src, StringBuilder dst, bool eol)
        {
            dst.Append(src);
            if(eol)
                dst.Append(Eol);
        }
    }
}
