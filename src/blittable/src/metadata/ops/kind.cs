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

    partial struct BitFlow
    {
        partial struct Meta
        {
            [MethodImpl(Inline), Op]
            public static BlittableKind kind(byte index)
                => skip(TypeKinds, clamp(index, (byte)(TypeKinds.Length - 1)));

            [MethodImpl(Inline), Op]
            static byte clamp(byte src, byte max)
                => src <= max ? src : max;
        }
    }
}