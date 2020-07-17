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

    using NK = NumericKind;

    partial class Enums
    {
        public static unsafe ulong untype<E>(E src)
            where E : unmanaged, Enum
            => typeof(E).GetEnumUnderlyingType().NumericKind() switch {
                NK.U8 => (ulong)e8u(src),
                NK.I8 => (ulong)e8i(src),
                NK.U16 => (ulong)e16u(src),
                NK.I16 => (ulong)e16i(src),
                NK.U32 => (ulong)e32u(src),
                NK.I32 => (ulong)e32i(src),
                NK.I64 => (ulong)e64i(src),
                NK.U64 => e64u(src),
                _ => 0ul,               
            };
    }   
}