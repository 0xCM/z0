//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static PrimalBits;

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static unsafe TypeCode typecode(in SystemTypeCodes src, byte index)
            => (TypeCode)(*(memory.address(src) + index).Pointer<byte>());

        [MethodImpl(Inline), Op]
        public static TypeCode typecode(ClrPrimalKind f)
            => (TypeCode)ClrPrimitives.select(f, Field.KindId);
    }
}