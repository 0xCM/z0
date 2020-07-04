//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static As;
    using static Typed;
    
    using NK = EnumTypeCode;

    [ApiHost]
    public readonly struct MultiFormatter : IApiHost<MultiFormatter>
    {
        public static MultiFormatter Service => default(MultiFormatter);

        [MethodImpl(Inline)]
        public string Format<T>(T src, N2 n, int? dmax = null)
            where T : unmanaged
                => Format_u(src,n, dmax);

        [MethodImpl(Inline)]
        public string Format<T>(T src, N8 n, int? dmax = null)
            where T : unmanaged
                => Format_u(src,n, dmax);

        [MethodImpl(Inline)]
        public string Format<T>(T src, N16 n, int? dmax = null)
            where T : unmanaged
                => Format_u(src,n, dmax);

        [MethodImpl(Inline)]
        public string Format<T>(T src, N10 n, int? dmax = null)
            where T : unmanaged
                => Format_u(src,n, dmax);

        public string FormatEnum<E>(E src, N2 n, int? dmax = null)
            where E : unmanaged, Enum        
                => Enums.typecode<E>() switch {
                    NK.U8 => Format(Enums.e8u(src), n, dmax),    
                    NK.I8 => Format(Enums.e8i(src), n, dmax),    
                    NK.I16 => Format(Enums.e16i(src), n, dmax),    
                    NK.U16 => Format(Enums.e16u(src), n, dmax),    
                    NK.I32 => Format(Enums.e32i(src), n, dmax),    
                    NK.U32 => Format(Enums.e32u(src), n, dmax),    
                    NK.I64 => Format(Enums.e64i(src), n, dmax),    
                    NK.U64 => Format(Enums.e64u(src), n, dmax),    
                    _ => src.ToString(),
                };

        public string FormatEnum<E>(E src, N8 n, int? dmax = null)
            where E : unmanaged, Enum        
                => Enums.typecode<E>() switch {
                    NK.U8 => Format(Enums.e8u(src), n, dmax),    
                    NK.I8 => Format(Enums.e8i(src), n, dmax),    
                    NK.I16 => Format(Enums.e16i(src), n, dmax),    
                    NK.U16 => Format(Enums.e16u(src), n, dmax),    
                    NK.I32 => Format(Enums.e32i(src), n, dmax),    
                    NK.U32 => Format(Enums.e32u(src), n, dmax),    
                    NK.I64 => Format(Enums.e64i(src), n, dmax),    
                    NK.U64 => Format(Enums.e64u(src), n, dmax),    
                    _ => src.ToString(),
                };

        public string FormatEnum<E>(E src, N16 n, int? dmax = null)
            where E : unmanaged, Enum        
                => Enums.typecode<E>() switch {
                    NK.U8 => Format(Enums.e8u(src), n, dmax),    
                    NK.I8 => Format(Enums.e8i(src), n, dmax),    
                    NK.I16 => Format(Enums.e16i(src), n, dmax),    
                    NK.U16 => Format(Enums.e16u(src), n, dmax),    
                    NK.I32 => Format(Enums.e32i(src), n, dmax),    
                    NK.U32 => Format(Enums.e32u(src), n, dmax),    
                    NK.I64 => Format(Enums.e64i(src), n, dmax),    
                    NK.U64 => Format(Enums.e64u(src), n, dmax),    
                    _ => src.ToString(),
                };

        public string FormatEnum<E>(E src, N10 n, int? dmax = null)
            where E : unmanaged, Enum        
                => Enums.typecode<E>() switch {
                    NK.U8 => Format(Enums.e8u(src), n, dmax),    
                    NK.I8 => Format(Enums.e8i(src), n, dmax),    
                    NK.I16 => Format(Enums.e16i(src), n, dmax),    
                    NK.U16 => Format(Enums.e16u(src), n, dmax),    
                    NK.I32 => Format(Enums.e32i(src), n, dmax),    
                    NK.U32 => Format(Enums.e32u(src), n, dmax),    
                    NK.I64 => Format(Enums.e64i(src), n, dmax),    
                    NK.U64 => Format(Enums.e64u(src), n, dmax),    
                    _ => src.ToString(),
                };

        public string FormatEnum<E>(E src, NumericBaseKind @base, int? dmax = null)
            where E : unmanaged, Enum        
                => Enums.typecode<E>() switch {
                    NK.U8 => Format(Enums.e8u(src), @base, dmax),    
                    NK.I8 => Format(Enums.e8i(src), @base, dmax),    
                    NK.I16 => Format(Enums.e16i(src), @base, dmax),    
                    NK.U16 => Format(Enums.e16u(src), @base, dmax),    
                    NK.I32 => Format(Enums.e32i(src), @base, dmax),    
                    NK.U32 => Format(Enums.e32u(src), @base, dmax),    
                    NK.I64 => Format(Enums.e64i(src), @base, dmax),    
                    NK.U64 => Format(Enums.e64u(src), @base, dmax),    
                    _ => src.ToString(),
                };        

        static string bitformat<T>(T src, int? dmax = null)
            where T : unmanaged
                => BitFormatter.format(src, dmax != null ? BitFormatter.limited(dmax.Value, dmax.Value)  : BitFormatter.configure());

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, N2 @base, int? dmax = null)
            => bitformat(src,dmax);

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, N8 @base, int? dmax = null)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, N10 @base, int? dmax = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, N16 @base, int? dmax = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(byte src, N2 @base, int? dmax = null)
            => bitformat(src,dmax);

        [MethodImpl(Inline), Op]
        public string Format(byte src, N8 @base, int? dmax = null)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(byte src, N10 @base, int? dmax = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(byte src, N16 @base, int? dmax = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(short src, N2 @base, int? dmax = null)
            => bitformat(src,dmax);

        [MethodImpl(Inline), Op]
        public string Format(short src, N8 @base, int? dmax = null)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(short src, N10 @base, int? dmax = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(short src, N16 @base, int? dmax = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(ushort src, N2 @base, int? dmax = null)
            => bitformat(src,dmax);

        [MethodImpl(Inline), Op]
        public string Format(ushort src, N8 @base, int? dmax = null)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(ushort src, N10 @base, int? dmax = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(ushort src, N16 @base, int? dmax = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(int src, N2 @base, int? dmax = null)
            => bitformat(src,dmax);

        [MethodImpl(Inline), Op]
        public string Format(int src, N8 @base, int? dmax = null)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(int src, N10 @base, int? dmax = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(int src, N16 @base, int? dmax = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(uint src, N2 @base, int? dmax = null)
            => bitformat(src,dmax);

        [MethodImpl(Inline), Op]
        public string Format(uint src, N8 @base, int? dmax = null)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(uint src, N10 @base, int? dmax = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(uint src, N16 @base, int? dmax = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(long src, N2 @base, int? dmax = null)
            => bitformat(src,dmax);

        [MethodImpl(Inline), Op]
        public string Format(long src, N8 @base, int? dmax = null)
            => Convert.ToString(src,8);

        [MethodImpl(Inline), Op]
        public string Format(long src, N10 @base, int? dmax = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(long src, N16 @base, int? dmax = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(ulong src, N2 @base, int? dmax = null)
            => bitformat(src,dmax);

        [MethodImpl(Inline), Op]
        public string Format(ulong src, N8 @base, int? dmax = null)
            => Convert.ToString((long)src,8);

        [MethodImpl(Inline), Op]
        public string Format(ulong src, N10 @base, int? dmax = null)
            => src.ToString();

        [MethodImpl(Inline), Op]
        public string Format(ulong src, N16 @base, int? dmax = null)
            => src.FormatHex(false, false);

        [MethodImpl(Inline), Op]
        public string Format(sbyte src, NumericBaseKind @base, int? dmax = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, dmax),
               NumericBaseKind.Base8 => Format(src, n8, dmax),
               NumericBaseKind.Base16 => Format(src, n16, dmax),
                _ => Format(src, n10, dmax),
            };

        [MethodImpl(Inline), Op]
        public string Format(byte src, NumericBaseKind @base, int? dmax = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, dmax),
               NumericBaseKind.Base8 => Format(src, n8, dmax),
               NumericBaseKind.Base16 => Format(src, n16, dmax),
                _ => Format(src, n10, dmax),
            };
 
        [MethodImpl(Inline), Op]
        public string Format(short src, NumericBaseKind @base, int? dmax = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, dmax),
               NumericBaseKind.Base8 => Format(src, n8, dmax),
               NumericBaseKind.Base16 => Format(src, n16, dmax),
                _ => Format(src, n10, dmax),
            };

        [MethodImpl(Inline), Op]
        public string Format(ushort src, NumericBaseKind @base, int? dmax = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, dmax),
               NumericBaseKind.Base8 => Format(src, n8, dmax),
               NumericBaseKind.Base16 => Format(src, n16, dmax),
                _ => Format(src, n10, dmax),
            };

        [MethodImpl(Inline), Op]
        public string Format(int src, NumericBaseKind @base, int? dmax = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, dmax),
               NumericBaseKind.Base8 => Format(src, n8, dmax),
               NumericBaseKind.Base16 => Format(src, n16, dmax),
                _ => Format(src, n10, dmax),
            };

        [MethodImpl(Inline), Op]
        public string Format(uint src, NumericBaseKind @base, int? dmax = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, dmax),
               NumericBaseKind.Base8 => Format(src, n8, dmax),
               NumericBaseKind.Base16 => Format(src, n16, dmax),
                _ => Format(src, n10, dmax),
            };

        [MethodImpl(Inline), Op]
        public string Format(long src, NumericBaseKind @base, int? dmax = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, dmax),
               NumericBaseKind.Base8 => Format(src, n8, dmax),
               NumericBaseKind.Base16 => Format(src, n16, dmax),
                _ => Format(src, n10, dmax),
            };

        [MethodImpl(Inline), Op]
        public string Format(ulong src, NumericBaseKind @base, int? dmax = null)
           => @base switch{
               NumericBaseKind.Base2 => Format(src, n2, dmax),
               NumericBaseKind.Base8 => Format(src, n8, dmax),
               NumericBaseKind.Base16 => Format(src, n16, dmax),
                _ => Format(src, n10, dmax),
            };

        [MethodImpl(Inline)]
        string Format_u<T>(T src, N10 n, int? dmax = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Format(uint8(src),n, dmax);
            else if(typeof(T) == typeof(ushort))
                return Format(uint16(src),n, dmax);
            else if(typeof(T) == typeof(uint))
                return Format(uint32(src),n, dmax);
            else if(typeof(T) == typeof(ulong))
                return Format(uint64(src),n, dmax);
            else
                return Format_i(src,n, dmax);
        }

        [MethodImpl(Inline)]
        string Format_i<T>(T src, N10 n, int? dmax = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Format(int8(src),n, dmax);
            else if(typeof(T) == typeof(short))
                return Format(int16(src),n, dmax);
            else if(typeof(T) == typeof(int))
                return Format(int32(src),n, dmax);
            else if(typeof(T) == typeof(long))
                return Format(int64(src),n, dmax);
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        string Format_u<T>(T src, N16 n, int? dmax = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Format(uint8(src),n, dmax);
            else if(typeof(T) == typeof(ushort))
                return Format(uint16(src),n, dmax);
            else if(typeof(T) == typeof(uint))
                return Format(uint32(src),n, dmax);
            else if(typeof(T) == typeof(ulong))
                return Format(uint64(src),n, dmax);
            else
                return Format_i(src,n, dmax);
        }

        [MethodImpl(Inline)]
        string Format_i<T>(T src, N16 n, int? dmax = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Format(int8(src),n, dmax);
            else if(typeof(T) == typeof(short))
                return Format(int16(src),n, dmax);
            else if(typeof(T) == typeof(int))
                return Format(int32(src),n, dmax);
            else if(typeof(T) == typeof(long))
                return Format(int64(src),n, dmax);
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        string Format_u<T>(T src, N2 n, int? dmax = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Format(uint8(src),n, dmax);
            else if(typeof(T) == typeof(ushort))
                return Format(uint16(src),n, dmax);
            else if(typeof(T) == typeof(uint))
                return Format(uint32(src),n, dmax);
            else if(typeof(T) == typeof(ulong))
                return Format(uint64(src),n, dmax);
            else
                return Format_i(src,n, dmax);
        }

        [MethodImpl(Inline)]
        string Format_i<T>(T src, N2 n, int? dmax = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Format(int8(src),n, dmax);
            else if(typeof(T) == typeof(short))
                return Format(int16(src),n, dmax);
            else if(typeof(T) == typeof(int))
                return Format(int32(src),n, dmax);
            else if(typeof(T) == typeof(long))
                return Format(int64(src),n, dmax);
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        string Format_u<T>(T src, N8 n, int? dmax = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Format(uint8(src),n, dmax);
            else if(typeof(T) == typeof(ushort))
                return Format(uint16(src),n, dmax);
            else if(typeof(T) == typeof(uint))
                return Format(uint32(src),n, dmax);
            else if(typeof(T) == typeof(ulong))
                return Format(uint64(src),n, dmax);
            else
                return Format_i(src,n, dmax);
        }

        [MethodImpl(Inline)]
        string Format_i<T>(T src, N8 n, int? dmax = null)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Format(int8(src),n, dmax);
            else if(typeof(T) == typeof(short))
                return Format(int16(src),n, dmax);
            else if(typeof(T) == typeof(int))
                return Format(int32(src),n, dmax);
            else if(typeof(T) == typeof(long))
                return Format(int64(src),n, dmax);
            else
                throw Unsupported.define<T>();
        }
    }
}