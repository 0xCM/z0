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

    partial struct AB
    {
        [MethodImpl(Inline), Op]
        public static ulong hash32(WfType src)
            => hash(src.Source) ^ hash(src.Target);

        [MethodImpl(Inline), Op]
        public static ulong hash64(WfType src)
            => (ulong)hash(src.Source) | ((ulong)hash(src.Target) << 32);
    }
}