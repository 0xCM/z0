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

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ClrType> nested(Type src)
            => memory.recover<Type,ClrType>(src.GetNestedTypes());
    }
}