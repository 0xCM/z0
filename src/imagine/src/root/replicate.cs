//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline), Op]
        public static Span<byte> replicate(SegRef src)
        {
            Span<byte> dst = sys.alloc<byte>(src.DataSize);            
            copy(src, dst);
            return dst;
        }
    }
}