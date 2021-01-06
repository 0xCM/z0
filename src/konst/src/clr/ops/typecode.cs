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

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static unsafe TypeCode typecode(in SystemTypeCodes src, byte index)
            => (TypeCode)(*(address(src) + index).Pointer<byte>());
    }
}