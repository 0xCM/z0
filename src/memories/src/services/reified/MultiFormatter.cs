//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
        
    using static Seed;
    using static Memories;
    using static NumericBaseKind;
    
    using NK = EnumNumericKind;

    [ApiHost]
    public readonly struct MultiFormatter : IApiHost<MultiFormatter>
    {
        [MethodImpl(Inline)]
        public string Format<T>(T src, N2 n)
            where T : unmanaged
                => Format_u(src,n);

        [MethodImpl(Inline)]
        public string Format<T>(T src, N8 n)
            where T : unmanaged
                => Format_u(src,n);

        [MethodImpl(Inline)]
        public string Format<T>(T src, N16 n)
            where T : unmanaged
                => Format_u(src,n);

        [MethodImpl(Inline)]
        public string Format<T>(T src, N10 n)
            where T : unmanaged
                => Format_u(src,n);

        public string FormatEnum<E>(E src, N2 n)
            where E : unmanaged, Enum        
                => Enums.kind<E>() switch {
                    NK.U8 => Format(Enums.u8(src), n),    
                    NK.I8 => Format(Enums.i8(src), n),    
                    NK.I16 => Format(Enums.i16(src), n),    
                    NK.U16 => Format(Enums.u16(src), n),    
                    NK.I32 => Format(Enums.i32(src), n),    
                    NK.U32 => Format(Enums.u32(src), n),    
                    NK.I64 => Format(Enums.i64(src), n),    
                    NK.U64 => Format(Enums.u64(src), n),    
                    _ => src.ToString(),
                };

        public string FormatEnum<E>(E src, N8 n)
            where E : unmanaged, Enum        
                => Enums.kind<E>() switch {
                    NK.U8 => Format(Enums.u8(src), n),    
                    NK.I8 => Format(Enums.i8(src), n),    
                    NK.I16 => Format(Enums.i16(src), n),    
                    NK.U16 => Format(Enums.u16(src), n),    
                    NK.I32 => Format(Enums.i32(src), n),    
                    NK.U32 => Format(Enums.u32(src), n),    
                    NK.I64 => Format(Enums.i64(src), n),    
                    NK.U64 => Format(Enums.u64(src), n),    
                    _ => src.ToString(),
                };

        public string FormatEnum<E>(E src, N16 n)
            where E : unmanaged, Enum        
                => Enums.kind<E>() switch {
                    NK.U8 => Format(Enums.u8(src), n),    
                    NK.I8 => Format(Enums.i8(src), n),    
                    NK.I16 => Format(Enums.i16(src), n),    
                    NK.U16 => Format(Enums.u16(src), n),    
                    NK.I32 => Format(Enums.i32(src), n),    
                    NK.U32 => Format(Enums.u32(src), n),    
                    NK.I64 => Format(Enums.i64(src), n),    
                    NK.U64 => Format(Enums.u64(src), n),    
                    _ => src.ToString(),
                };

        public string FormatEnum<E>(E src, N10 n)
            where E : unmanaged, Enum        
                => Enums.kind<E>() switch {
                    NK.U8 => Format(Enums.u8(src), n),    
                    NK.I8 => Format(Enums.i8(src), n),    
                    NK.I16 => Format(Enums.i16(src), n),    
                    NK.U16 => Format(Enums.u16(src), n),    
                    NK.I32 => Format(Enums.i32(src), n),    
                    NK.U32 => Format(Enums.u32(src), n),    
                    NK.I64 => Format(Enums.i64(src), n),    
                    NK.U64 => Format(Enums.u64(src), n),    
                    _ => src.ToString(),
                };

        public string FormatEnum<E>(E src, NumericBaseKind @base)
            where E : unmanaged, Enum        
                => Enums.kind<E>() switch {
                    NK.U8 => Format(Enums.u8(src), @base),    
                    NK.I8 => Format(Enums.i8(src), @base),    
                    NK.I16 => Format(Enums.i16(src), @base),    
                    NK.U16 => Format(Enums.u16(src), @base),    
                    NK.I32 => Format(Enums.i32(src), @base),    
                    NK.U32 => Format(Enums.u32(src), @base),    
                    NK.I64 => Format(Enums.i64(src), @base),    
                    NK.U64 => Format(Enums.u64(src), @base),    
                    _ => src.ToString(),
                };        

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, N2 @base)
            => BitFormatter.format(src);

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, N8 @base)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, N10 @base)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, N16 @base)
            => src.FormatHex(true, false);

        [MethodImpl(Inline), Op]
        public string Format(byte src, N2 @base)
            => BitFormatter.format(src);

        [MethodImpl(Inline), Op]
        public string Format(byte src, N8 @base)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(byte src, N10 @base)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(byte src, N16 @base)
            => src.FormatHex(true, false);

        [MethodImpl(Inline), Op]
        public string Format(short src, N2 @base)
            => BitFormatter.format(src);

        [MethodImpl(Inline), Op]
        public string Format(short src, N8 @base)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(short src, N10 @base)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(short src, N16 @base)
            => src.FormatHex(true, false);

        [MethodImpl(Inline), Op]
        public string Format(ushort src, N2 @base)
            => BitFormatter.format(src);

        [MethodImpl(Inline), Op]
        public string Format(ushort src, N8 @base)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(ushort src, N10 @base)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(ushort src, N16 @base)
            => src.FormatHex(true, false);

        [MethodImpl(Inline), Op]
        public string Format(int src, N2 @base)
            => BitFormatter.format(src);

        [MethodImpl(Inline), Op]
        public string Format(int src, N8 @base)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(int src, N10 @base)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(int src, N16 @base)
            => src.FormatHex(true, false);

        [MethodImpl(Inline), Op]
        public string Format(uint src, N2 @base)
            => BitFormatter.format(src);

        [MethodImpl(Inline), Op]
        public string Format(uint src, N8 @base)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(uint src, N10 @base)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(uint src, N16 @base)
            => src.FormatHex(true, false);

        [MethodImpl(Inline), Op]
        public string Format(long src, N2 @base)
            => BitFormatter.format(src);

        [MethodImpl(Inline), Op]
        public string Format(long src, N8 @base)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(long src, N10 @base)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(long src, N16 @base)
            => src.FormatHex(true, false);

        [MethodImpl(Inline), Op]
        public string Format(ulong src, N2 @base)
            => BitFormatter.format(src);

        [MethodImpl(Inline), Op]
        public string Format(ulong src, N8 @base)
            => Convert.ToString((long)src,8);

        [MethodImpl(Inline), Op]
        public string Format(ulong src, N10 @base)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(ulong src, N16 @base)
            => src.FormatHex(true, false);

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, NumericBaseKind @base)
           => @base switch{
                B => Format(src, n2),
                O => Format(src, n8),
                X => Format(src, n16),
                _ => Format(src, n10),
            };

        [MethodImpl(Inline), Op]
        public string Format(byte src, NumericBaseKind @base)
           => @base switch{
                B => Format(src, n2),
                O => Format(src, n8),
                X => Format(src, n16),
                _ => Format(src, n10),
            };
 
        [MethodImpl(Inline), Op]
        public string Format(short src, NumericBaseKind @base)
           => @base switch{
                B => Format(src, n2),
                O => Format(src, n8),
                X => Format(src, n16),
                _ => Format(src, n10),
            };

        [MethodImpl(Inline), Op]
        public string Format(ushort src, NumericBaseKind @base)
           => @base switch{
                B => Format(src, n2),
                O => Format(src, n8),
                X => Format(src, n16),
                _ => Format(src, n10),
            };

        [MethodImpl(Inline), Op]
        public string Format(int src, NumericBaseKind @base)
           => @base switch{
                B => Format(src, n2),
                O => Format(src, n8),
                X => Format(src, n16),
                _ => Format(src, n10),
            };

        [MethodImpl(Inline), Op]
        public string Format(uint src, NumericBaseKind @base)
           => @base switch{
                B => Format(src, n2),
                O => Format(src, n8),
                X => Format(src, n16),
                _ => Format(src, n10),
            };

        [MethodImpl(Inline), Op]
        public string Format(long src, NumericBaseKind @base)
           => @base switch{
                B => Format(src, n2),
                O => Format(src, n8),
                X => Format(src, n16),
                _ => Format(src, n10),
            };

        [MethodImpl(Inline), Op]
        public string Format(ulong src, NumericBaseKind @base)
           => @base switch{
                B => Format(src, n2),
                O => Format(src, n8),
                X => Format(src, n16),
                _ => Format(src, n10),
            };

        [MethodImpl(Inline)]
        string Format_u<T>(T src, N10 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Format(uint8(src),n);
            else if(typeof(T) == typeof(ushort))
                return Format(uint16(src),n);
            else if(typeof(T) == typeof(uint))
                return Format(uint32(src),n);
            else if(typeof(T) == typeof(ulong))
                return Format(uint64(src),n);
            else
                return Format_i(src,n);
        }

        [MethodImpl(Inline)]
        string Format_i<T>(T src, N10 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Format(int8(src),n);
            else if(typeof(T) == typeof(short))
                return Format(int16(src),n);
            else if(typeof(T) == typeof(int))
                return Format(int32(src),n);
            else if(typeof(T) == typeof(long))
                return Format(int64(src),n);
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        string Format_u<T>(T src, N16 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Format(uint8(src),n);
            else if(typeof(T) == typeof(ushort))
                return Format(uint16(src),n);
            else if(typeof(T) == typeof(uint))
                return Format(uint32(src),n);
            else if(typeof(T) == typeof(ulong))
                return Format(uint64(src),n);
            else
                return Format_i(src,n);
        }

        [MethodImpl(Inline)]
        string Format_i<T>(T src, N16 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Format(int8(src),n);
            else if(typeof(T) == typeof(short))
                return Format(int16(src),n);
            else if(typeof(T) == typeof(int))
                return Format(int32(src),n);
            else if(typeof(T) == typeof(long))
                return Format(int64(src),n);
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        string Format_u<T>(T src, N2 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Format(uint8(src),n);
            else if(typeof(T) == typeof(ushort))
                return Format(uint16(src),n);
            else if(typeof(T) == typeof(uint))
                return Format(uint32(src),n);
            else if(typeof(T) == typeof(ulong))
                return Format(uint64(src),n);
            else
                return Format_i(src,n);
        }

        [MethodImpl(Inline)]
        string Format_i<T>(T src, N2 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Format(int8(src),n);
            else if(typeof(T) == typeof(short))
                return Format(int16(src),n);
            else if(typeof(T) == typeof(int))
                return Format(int32(src),n);
            else if(typeof(T) == typeof(long))
                return Format(int64(src),n);
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        string Format_u<T>(T src, N8 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Format(uint8(src),n);
            else if(typeof(T) == typeof(ushort))
                return Format(uint16(src),n);
            else if(typeof(T) == typeof(uint))
                return Format(uint32(src),n);
            else if(typeof(T) == typeof(ulong))
                return Format(uint64(src),n);
            else
                return Format_i(src,n);
        }

        [MethodImpl(Inline)]
        string Format_i<T>(T src, N8 n)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Format(int8(src),n);
            else if(typeof(T) == typeof(short))
                return Format(int16(src),n);
            else if(typeof(T) == typeof(int))
                return Format(int32(src),n);
            else if(typeof(T) == typeof(long))
                return Format(int64(src),n);
            else
                throw Unsupported.define<T>();
        }
    }
}