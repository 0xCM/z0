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
            var vSrc = vload(w128, first(recover<char,byte>(src)));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref CharBlock32 vcopy(ReadOnlySpan<char> src, ref CharBlock32 dst)
        {
            var vSrc = vload(w256, u8(dst));
            vstore(vSrc, ref u8(dst));
            return ref dst;
        }
    }
}