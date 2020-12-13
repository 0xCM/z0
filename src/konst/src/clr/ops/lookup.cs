//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ClrQuery
    {
        [MethodImpl(Inline), Op]
        public static unsafe TypeCode lookup(in ClrTypeCodes src, byte index)
            => (TypeCode)(*(z.address(src) + index).Pointer<byte>());
    }
}