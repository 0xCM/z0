//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public unsafe static ReadOnlySpan<char> segment(in ResIdentity<char> res, int i0, int i1)
            => z.segment((char*)res.Address, i0, i1);        

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> segment(in ResIdentity<byte> res, int i0, int i1)
            => memory.view<byte>(res.Address, (i1 - i0 + 1)); 
    }
}