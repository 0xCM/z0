//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using NK = NumericKind;

    partial class Enums
    {
        [MethodImpl(Inline)]
        public static EnumDatasetEntry untyped<E,T>(in EnumDatasetEntry<E,T> src)
            where E : unmanaged, Enum
            where T : unmanaged
                => new EnumDatasetEntry(src.Token, src.EnumId, src.Index, src.Name, Variant.from(src.ScalarValue), src.Description);

        public static unsafe ulong untyped<E>(E src)
            where E : unmanaged, Enum
                => typeof(E).GetEnumUnderlyingType().NumericKind() switch {
                    NK.U8 => (ulong)EnumValue.e8u(src),
                    NK.I8 => (ulong)EnumValue.e8i(src),
                    NK.U16 => (ulong)EnumValue.e16u(src),
                    NK.I16 => (ulong)EnumValue.e16i(src),
                    NK.U32 => (ulong)EnumValue.e32u(src),
                    NK.I32 => (ulong)EnumValue.e32i(src),
                    NK.I64 => (ulong)EnumValue.e64i(src),
                    NK.U64 => EnumValue.e64u(src),
                    _ => 0ul,
                };
    }
}