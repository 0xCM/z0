//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct cpu
    {
        [MethodImpl(Inline), Op]
        public static ref CharBlock16 vcopy(ReadOnlySpan<char> src, ref CharBlock16 dst)
        {
            vstore(vload(w128, first(recover<char,byte>(src))), ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CharBlock32 vcopy(ReadOnlySpan<char> src, ref CharBlock32 dst)
        {
            vstore(vload(w256, u8(dst)), ref u8(dst));
            return ref dst;
        }
    }
}