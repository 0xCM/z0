//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct ClrArtifacts
    {
        [MethodImpl(Inline), Op]
        public static unsafe TypeCode lookup(in ClrTypeCodes src, byte index)
        {
            var address = z.address(src);
            return (TypeCode)(*(address + index).Pointer<byte>());
        }
    }
}