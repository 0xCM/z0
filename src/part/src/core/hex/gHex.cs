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
    using static HexFormatSpecs;

    [ApiHost]
    public readonly partial struct gHex
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static byte value<H>(H h= default)
            where H : unmanaged, IHexType
                => (byte)h.Value;

        [MethodImpl(Inline)]
        public static HexIndex<K> index<K>(K[] src)
            where K : unmanaged, IHexNumber
                => new HexIndex<K>(src);

        [MethodImpl(Inline)]
        public static HexString<K> hexstring<K>()
            where K : unmanaged, Enum
        {
            if(typeof(K) == typeof(Hex1Seq))
                return generic<K>(new HexString<Hex1Seq>(Hex1Text.x00));
            else if(typeof(K) == typeof(Hex2Seq))
                return generic<K>(new HexString<Hex2Seq>(Hex2Text.x00));
            else if(typeof(K) == typeof(Hex3Seq))
                return generic<K>(new HexString<Hex3Seq>(Hex3Text.x00));
            else if(typeof(K) == typeof(Hex4Seq))
                return generic<K>(new HexString<Hex4Seq>(Hex4Text.x00));
            else
                return HexString<K>.Empty;
        }

        [MethodImpl(Inline)]
        public static ref HexString<K> generic<K>(in HexString<Hex1Seq> src)
            where K : unmanaged
                => ref @as<HexString<Hex1Seq>,HexString<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexString<K> generic<K>(in HexString<Hex2Seq> src)
            where K : unmanaged
                => ref @as<HexString<Hex2Seq>,HexString<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexString<K> generic<K>(in HexString<Hex3Seq> src)
            where K : unmanaged
                => ref @as<HexString<Hex3Seq>,HexString<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexString<K> generic<K>(in HexString<Hex4Seq> src)
            where K : unmanaged
                => ref @as<HexString<Hex4Seq>, HexString<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexStrings<K> generic<K>(in HexStrings<Hex1Seq> src)
            where K : unmanaged
                => ref @as<HexStrings<Hex1Seq>, HexStrings<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexStrings<K> generic<K>(in HexStrings<Hex2Seq> src)
            where K : unmanaged
                => ref @as<HexStrings<Hex2Seq>, HexStrings<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexStrings<K> generic<K>(in HexStrings<Hex3Seq> src)
            where K : unmanaged
                => ref @as<HexStrings<Hex3Seq>, HexStrings<K>>(edit(src));

        [MethodImpl(Inline)]
        public static ref HexStrings<K> generic<K>(in HexStrings<Hex4Seq> src)
            where K : unmanaged
                => ref @as<HexStrings<Hex4Seq>, HexStrings<K>>(edit(src));

        [Op, Closures(Closure)]
        public static Index<HexCodeLo> digits<T>(in T src, LowerCased @case)
            where T : struct
        {
            var count = size<T>();
            var dst = alloc<HexCodeLo>(count*2);
            digits(src,dst);
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void digits<T>(in T src, Span<HexCodeLo> dst)
            where T : struct
        {
            var count = size<T>();
            ref readonly var bytes = ref @as<T,byte>(src);
            var j = count*2 - 1;

            for(var i=0u; i<count; i++)
            {
                ref readonly var d = ref skip(bytes,i);
                seek(dst, j--) = Hex.code(n4, LowerCase, d);
                seek(dst, j--) = Hex.code(n4, LowerCase, Bytes.srl(d, 4));
            }
        }

        [Op, Closures(Closure)]
        public static string format<T>(in T src)
            where T : struct
        {
            var count = size<T>();
            var dst = span<char>(count*2);
            chars(src,dst);
            return dst.ToString();
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void chars<T>(in T src, Span<char> dst)
            where T : struct
        {
            var count = size<T>();
            ref readonly var bytes = ref @as<T,byte>(src);
            var j = root.min(count*2 - 1, dst.Length);
            for(var i=0u; i<count; i++)
            {
                ref readonly var d = ref skip(bytes,i);
                seek(dst, j--) = (char)Hex.code(n4, LowerCase, d);
                seek(dst, j--) = (char)Hex.code(n4, LowerCase, Bytes.srl(d, 4));
            }
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<char> chars<T>(Base16 @base, UpperCased @case, T value)
            where T : unmanaged
                => chars_u(@base, @case, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void chars<T>(Base16 @base, UpperCased @case, T value, Span<char> dst, int offset)
            where T : unmanaged
                => chars_u(@base, @case, value, dst, offset);

        /// <summary>
        /// Presents the source value as a sequence of hex symbols
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="case">The case selector</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<HexSym> hexchar<C>(C @case, byte src)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return recover<char,HexSym>(span(src.ToString(LC)));
            else
                return recover<char,HexSym>(span(src.ToString(UC)));
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars_u<T>(Base16 @base, UpperCased @case, T value)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Hex.chars(@case, uint8(value));
            else if(typeof(T) == typeof(ushort))
                return Hex.chars(@case, int16(value));
            else if(typeof(T) == typeof(uint))
                return Hex.chars(@case, uint32(value));
            else if(typeof(T) == typeof(ulong))
                return Hex.chars(@case, uint64(value));
            else
                return chars_i(@base, @case, value);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars_i<T>(Base16 @base, UpperCased @case, T value)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Hex.chars(@case, int8(value));
            else if(typeof(T) == typeof(short))
                return Hex.chars(@case, int16(value));
            else if(typeof(T) == typeof(int))
                return Hex.chars(@case, int32(value));
            else if(typeof(T) == typeof(long))
                return Hex.chars(@case, int64(value));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static void chars_u<T>(Base16 @base, UpperCased @case, T value, Span<char> dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                Hex.chars(@case, uint8(value), dst, offset);
            else if(typeof(T) == typeof(ushort))
                Hex.chars(@case, uint16(value), dst, offset);
            else if(typeof(T) == typeof(uint))
                Hex.chars(@case, uint32(value), dst, offset);
            else if(typeof(T) == typeof(ulong))
                Hex.chars(@case, uint64(value), dst, offset);
            else
                chars_i(@base, @case, value,dst,offset);
        }

        [MethodImpl(Inline)]
        static void chars_i<T>(Base16 @base, UpperCased @case, T value, Span<char> dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                Hex.chars(@case, int8(value), dst, offset);
            else if(typeof(T) == typeof(short))
                Hex.chars(@case, int16(value), dst, offset);
            else if(typeof(T) == typeof(int))
                Hex.chars(@case, int32(value), dst, offset);
            else if(typeof(T) == typeof(long))
                Hex.chars(@case, int64(value), dst, offset);
            else
                throw no<T>();
        }
    }
}