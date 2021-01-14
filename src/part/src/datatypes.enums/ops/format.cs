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

    using NK = ClrEnumCode;

    partial struct EnumValue
    {
        public static string format<E>(E src, Base2 n, int? digits = null)
            where E : unmanaged, Enum
                => ClrPrimitives.ecode<E>() switch {
                    NK.U8 => Numeric.Format(EnumValue.e8u(src), n, digits),
                    NK.I8 => Numeric.Format(EnumValue.e8i(src), n, digits),
                    NK.I16 => Numeric.Format(EnumValue.e16i(src), n, digits),
                    NK.U16 => Numeric.Format(EnumValue.e16u(src), n, digits),
                    NK.I32 => Numeric.Format(EnumValue.e32i(src), n, digits),
                    NK.U32 => Numeric.Format(EnumValue.e32u(src), n, digits),
                    NK.I64 => Numeric.Format(EnumValue.e64i(src), n, digits),
                    NK.U64 => Numeric.Format(EnumValue.e64u(src), n, digits),
                    _ => src.ToString(),
                };

        public static string format<E>(E src, Base8 n)
            where E : unmanaged, Enum
                => ClrPrimitives.ecode<E>() switch {
                    NK.U8 => Numeric.Format(EnumValue.e8u(src), n),
                    NK.I8 => Numeric.Format(EnumValue.e8i(src), n),
                    NK.I16 => Numeric.Format(EnumValue.e16i(src), n),
                    NK.U16 => Numeric.Format(EnumValue.e16u(src), n),
                    NK.I32 => Numeric.Format(EnumValue.e32i(src), n),
                    NK.U32 => Numeric.Format(EnumValue.e32u(src), n),
                    NK.I64 => Numeric.Format(EnumValue.e64i(src), n),
                    NK.U64 => Numeric.Format(EnumValue.e64u(src), n),
                    _ => src.ToString(),
                };

        public static string format<E>(E src, Base16 n, int? digits = null)
            where E : unmanaged, Enum
                => ClrPrimitives.ecode<E>() switch {
                    NK.U8 => Numeric.Format(EnumValue.e8u(src), n, digits),
                    NK.I8 => Numeric.Format(EnumValue.e8i(src), n, digits),
                    NK.I16 => Numeric.Format(EnumValue.e16i(src), n, digits),
                    NK.U16 => Numeric.Format(EnumValue.e16u(src), n, digits),
                    NK.I32 => Numeric.Format(EnumValue.e32i(src), n, digits),
                    NK.U32 => Numeric.Format(EnumValue.e32u(src), n, digits),
                    NK.I64 => Numeric.Format(EnumValue.e64i(src), n, digits),
                    NK.U64 => Numeric.Format(EnumValue.e64u(src), n, digits),
                    _ => src.ToString(),
                };

        public static string format<E>(E src, Base10 b, int? digits = null)
            where E : unmanaged, Enum
                => ClrPrimitives.ecode<E>() switch {
                    NK.U8 => Numeric.Format(EnumValue.e8u(src), b, digits),
                    NK.I8 => Numeric.Format(EnumValue.e8i(src), b, digits),
                    NK.I16 => Numeric.Format(EnumValue.e16i(src), b, digits),
                    NK.U16 => Numeric.Format(EnumValue.e16u(src), b, digits),
                    NK.I32 => Numeric.Format(EnumValue.e32i(src), b, digits),
                    NK.U32 => Numeric.Format(EnumValue.e32u(src), b, digits),
                    NK.I64 => Numeric.Format(EnumValue.e64i(src), b, digits),
                    NK.U64 => Numeric.Format(EnumValue.e64u(src), b, digits),
                    _ => src.ToString(),
                };

        public static string format<E>(E src, NumericBaseKind b, int? digits = null)
            where E : unmanaged, Enum
                => ClrPrimitives.ecode<E>() switch {
                    NK.U8 => Numeric.Format(EnumValue.e8u(src), b, digits),
                    NK.I8 => Numeric.Format(EnumValue.e8i(src), b, digits),
                    NK.I16 => Numeric.Format(EnumValue.e16i(src), b, digits),
                    NK.U16 => Numeric.Format(EnumValue.e16u(src), b, digits),
                    NK.I32 => Numeric.Format(EnumValue.e32i(src), b, digits),
                    NK.U32 => Numeric.Format(EnumValue.e32u(src), b, digits),
                    NK.I64 => Numeric.Format(EnumValue.e64i(src), b, digits),
                    NK.U64 => Numeric.Format(EnumValue.e64u(src), b, digits),
                    _ => src.ToString(),
                };
    }
}