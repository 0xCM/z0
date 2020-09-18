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

    partial struct Flow
    {
        [MethodImpl(Inline), Op]
        public static ulong hash32(ArrowType src)
            => hash(src.Source) ^ hash(src.Target);

        [MethodImpl(Inline), Op]
        public static ulong hash64(ArrowType src)
            => (ulong)hash(src.Source) | ((ulong)hash(src.Target) << 32);
    }
}