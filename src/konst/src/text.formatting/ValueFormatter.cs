//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    using NK = ClrEnumCode;

    [ApiHost]
    public readonly struct ValueFormatter
    {
        [MethodImpl(Inline), Op,Closures(Integers)]
        public string FormatPrimal<T>(T src, N2 n, int? digits = null)
            where T : unmanaged
                => Format_u(src,n, digits);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public string FormatPrimal<T>(T src, N8 n, int? digits = null)
            where T : unmanaged
                => Format_u(src,n, digits);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public string FormatPrimal<T>(T src, N16 n, int? digits = null)
            where T : unmanaged
                => Format_u(src,n, digits);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public string FormatPrimal<T>(T src, N10 n, int? digits = null)
            where T : unmanaged
                => Format_u(src,n, digits);

        public string FormatEnum<E>(E src, N2 n, int? digits = null)
            where E : unmanaged, Enum
                => ClrPrimitives.ecode<E>() switch {
                    NK.U8 => Format(Enums.e8u(src), n, digits),
                    NK.I8 => Format(Enums.e8i(src), n, digits),
                    NK.I16 => Format(Enums.e16i(src), n, digits),
                    NK.U16 => Format(Enums.e16u(src), n, digits),
                    NK.I32 => Format(Enums.e32i(src), n, digits),
                    NK.U32 => Format(Enums.e32u(src), n, digits),
                    NK.I64 => Format(Enums.e64i(src), n, digits),
                    NK.U64 => Format(Enums.e64u(src), n, digits),
                    _ => src.ToString(),
                };

        public string FormatEnum<E>(E src, N8 n)
            where E : unmanaged, Enum
                => ClrPrimitives.ecode<E>() switch {
                    NK.U8 => Format(Enums.e8u(src), n),
                    NK.I8 => Format(Enums.e8i(src), n),
                    NK.I16 => Format(Enums.e16i(src), n),
                    NK.U16 => Format(Enums.e16u(src), n),
                    NK.I32 => Format(Enums.e32i(src), n),
                    NK.U32 => Format(Enums.e32u(src), n),
                    NK.I64 => Format(Enums.e64i(src), n),
                    NK.U64 => Format(Enums.e64u(src), n),
                    _ => src.ToString(),
                };

        public string FormatEnum<E>(E src, N16 n, int? digits = null)
            where E : unmanaged, Enum
                => ClrPrimitives.ecode<E>() switch {
                    NK.U8 => Format(Enums.e8u(src), n, digits),
                    NK.I8 => Format(Enums.e8i(src), n, digits),
                    NK.I16 => Format(Enums.e16i(src), n, digits),
                    NK.U16 => Format(Enums.e16u(src), n, digits),
                    NK.I32 => Format(Enums.e32i(src), n, digits),
                    NK.U32 => Format(Enums.e32u(src), n, digits),
                    NK.I64 => Format(Enums.e64i(src), n, digits),
                    NK.U64 => Format(Enums.e64u(src), n, digits),
                    _ => src.ToString(),
                };

        public string FormatEnum<E>(E src, N10 n, int? digits = null)
            where E : unmanaged, Enum
                => ClrPrimitives.ecode<E>() switch {
                    NK.U8 => Format(Enums.e8u(src), n, digits),
                    NK.I8 => Format(Enums.e8i(src), n, digits),
                    NK.I16 => Format(Enums.e16i(src), n, digits),
                    NK.U16 => Format(Enums.e16u(src), n, digits),
                    NK.I32 => Format(Enums.e32i(src), n, digits),
                    NK.U32 => Format(Enums.e32u(src), n, digits),
                    NK.I64 => Format(Enums.e64i(src), n, digits),
                    NK.U64 => Format(Enums.e64u(src), n, digits),
                    _ => src.ToString(),
                };

        public string FormatEnum<E>(E src, NumericBaseKind @base, int? digits = null)
            where E : unmanaged, Enum
                => ClrPrimitives.ecode<E>() switch {
                    NK.U8 => Format(Enums.e8u(src), @base, digits),
                    NK.I8 => Format(Enums.e8i(src), @base, digits),
                    NK.I16 => Format(Enums.e16i(src), @base, digits),
                    NK.U16 => Format(Enums.e16u(src), @base, digits),
                    NK.I32 => Format(Enums.e32i(src), @base, digits),
                    NK.U32 => Format(Enums.e32u(src), @base, digits),
                    NK.I64 => Format(Enums.e64i(src), @base, digits),
                    NK.U64 => Format(Enums.e64u(src), @base, digits),
                    _ => src.ToString(),
                };

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, N2 @base, int? digits = null)
            => bitformat(src, digits);

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, N8 @base, int? digits = null)
            => Convert.ToString(src, 8);

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, N10 @base, int? digits = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, N16 @base, int? digits = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(byte src, N2 @base, int? digits = null)
            => bitformat(src,digits);

        [MethodImpl(Inline), Op]
        public string Format(byte src, N8 @base, int? digits = null)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(byte src, N10 @base, int? digits = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(byte src, N16 @base, int? digits = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(short src, N2 @base, int? digits = null)
            => bitformat(src,digits);

        [MethodImpl(Inline), Op]
        public string Format(short src, N8 @base, int? digits = null)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(short src, N10 @base, int? digits = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(short src, N16 @base, int? digits = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(ushort src, N2 @base, int? digits = null)
            => bitformat(src,digits);

        [MethodImpl(Inline), Op]
        public string Format(ushort src, N8 @base, int? digits = null)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(ushort src, N10 @base, int? digits = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(ushort src, N16 @base, int? digits = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(int src, N2 @base, int? digits = null)
            => bitformat(src,digits);

        [MethodImpl(Inline), Op]
        public string Format(int src, N8 @base, int? digits = null)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(int src, N10 @base, int? digits = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(int src, N16 @base, int? digits = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(uint src, N2 @base, int? digits = null)
            => bitformat(src,digits);

        [MethodImpl(Inline), Op]
        public string Format(uint src, N8 @base, int? digits = null)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(uint src, N10 @base, int? digits = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(uint src, N16 @base, int? digits = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(long src, N2 @base, int? digits = null)
            => bitformat(src,digits);

        [MethodImpl(Inline), Op]
        public string Format(long src, N8 @base, int? digits = null)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(long src, N10 @base, int? digits = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(long src, N16 @base, int? digits = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(ulong src, N2 @base, int? digits = null)
            => bitformat(src,digits);

        [MethodImpl(Inline), Op]
        public string Format(ulong src, N8 @base, int? digits = null)
            => Convert.ToString((long)src,8);

        [MethodImpl(Inline), Op]
        public string Format(ulong src, N10 @base, int? digits = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(ulong src, N16 @base, int? digits = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, NumericBaseKind @base, int? digits = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, digits),
               NumericBaseKind.Base8 => Format(src, n8, digits),
               NumericBaseKind.Base16 => Format(src, n16, digits),
                _ => Format(src, n10, digits),
            };

        [MethodImpl(Inline), Op]
        public string Format(byte src, NumericBaseKind @base, int? digits = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, digits),
               NumericBaseKind.Base8 => Format(src, n8, digits),
               NumericBaseKind.Base16 => Format(src, n16, digits),
                _ => Format(src, n10, digits),
            };

        [MethodImpl(Inline), Op]
        public string Format(short src, NumericBaseKind @base, int? digits = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, digits),
               NumericBaseKind.Base8 => Format(src, n8, digits),
               NumericBaseKind.Base16 => Format(src, n16, digits),
                _ => Format(src, n10, digits),
            };

        [MethodImpl(Inline), Op]
        public string Format(ushort src, NumericBaseKind @base, int? digits = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, digits),
               NumericBaseKind.Base8 => Format(src, n8, digits),
               NumericBaseKind.Base16 => Format(src, n16, digits),
                _ => Format(src, n10, digits),
            };

        [MethodImpl(Inline), Op]
        public string Format(int src, NumericBaseKind @base, int? digits = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, digits),
               NumericBaseKind.Base8 => Format(src, n8, digits),
               NumericBaseKind.Base16 => Format(src, n16, digits),
                _ => Format(src, n10, digits),
            };

        [MethodImpl(Inline), Op]
        public string Format(uint src, NumericBaseKind @base, int? digits = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, digits),
               NumericBaseKind.Base8 => Format(src, n8, digits),
               NumericBaseKind.Base16 => Format(src, n16, digits),
                _ => Format(src, n10, digits),
            };

        [MethodImpl(Inline), Op]
        public string Format(long src, NumericBaseKind @base, int? digits = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, digits),
               NumericBaseKind.Base8 => Format(src, n8, digits),
               NumericBaseKind.Base16 => Format(src, n16, digits),
                _ => Format(src, n10, digits),
            };

        [MethodImpl(Inline), Op]
        public string Format(ulong src, NumericBaseKind @base, int? digits = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, digits),
               NumericBaseKind.Base8 => Format(src, n8, digits),
               NumericBaseKind.Base16 => Format(src, n16, digits),
                _ => Format(src, n10, digits),
            };



        [MethodImpl(Inline)]
        string Format_u<T>(T src, N10 n, int? digits = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Format(uint8(src),n, digits);
            else if(typeof(T) == typeof(ushort))
                return Format(uint16(src),n, digits);
            else if(typeof(T) == typeof(uint))
                return Format(uint32(src),n, digits);
            else if(typeof(T) == typeof(ulong))
                return Format(uint64(src),n, digits);
            else
                return Format_i(src,n, digits);
        }

        [MethodImpl(Inline)]
        string Format_i<T>(T src, N10 n, int? digits = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Format(int8(src),n, digits);
            else if(typeof(T) == typeof(short))
                return Format(int16(src),n, digits);
            else if(typeof(T) == typeof(int))
                return Format(int32(src),n, digits);
            else if(typeof(T) == typeof(long))
                return Format(int64(src),n, digits);
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        string Format_u<T>(T src, N16 n, int? digits = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Format(uint8(src),n, digits);
            else if(typeof(T) == typeof(ushort))
                return Format(uint16(src),n, digits);
            else if(typeof(T) == typeof(uint))
                return Format(uint32(src),n, digits);
            else if(typeof(T) == typeof(ulong))
                return Format(uint64(src),n, digits);
            else
                return Format_i(src,n, digits);
        }

        [MethodImpl(Inline)]
        string Format_i<T>(T src, N16 n, int? digits = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Format(int8(src),n, digits);
            else if(typeof(T) == typeof(short))
                return Format(int16(src),n, digits);
            else if(typeof(T) == typeof(int))
                return Format(int32(src),n, digits);
            else if(typeof(T) == typeof(long))
                return Format(int64(src),n, digits);
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        string Format_u<T>(T src, N2 n, int? digits = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Format(uint8(src),n, digits);
            else if(typeof(T) == typeof(ushort))
                return Format(uint16(src),n, digits);
            else if(typeof(T) == typeof(uint))
                return Format(uint32(src),n, digits);
            else if(typeof(T) == typeof(ulong))
                return Format(uint64(src),n, digits);
            else
                return Format_i(src,n, digits);
        }

        [MethodImpl(Inline)]
        string Format_i<T>(T src, N2 n, int? digits = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Format(int8(src),n, digits);
            else if(typeof(T) == typeof(short))
                return Format(int16(src),n, digits);
            else if(typeof(T) == typeof(int))
                return Format(int32(src),n, digits);
            else if(typeof(T) == typeof(long))
                return Format(int64(src),n, digits);
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        string Format_u<T>(T src, N8 n, int? digits = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Format(uint8(src),n, digits);
            else if(typeof(T) == typeof(ushort))
                return Format(uint16(src),n, digits);
            else if(typeof(T) == typeof(uint))
                return Format(uint32(src),n, digits);
            else if(typeof(T) == typeof(ulong))
                return Format(uint64(src),n, digits);
            else
                return Format_i(src,n, digits);
        }

        [MethodImpl(Inline)]
        string Format_i<T>(T src, N8 n, int? digits = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Format(int8(src), n, digits);
            else if(typeof(T) == typeof(short))
                return Format(int16(src), n, digits);
            else if(typeof(T) == typeof(int))
                return Format(int32(src), n, digits);
            else if(typeof(T) == typeof(long))
                return Format(int64(src), n, digits);
            else
                throw no<T>();
        }

        static string bitformat<T>(T src, int? digits = null)
            where T : unmanaged
                => BitFormatter.format(src, digits != null ? BitFormatter.limited((uint)digits.Value, digits.Value)  : BitFormatter.configure());
    }
}