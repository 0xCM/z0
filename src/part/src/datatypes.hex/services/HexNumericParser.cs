//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Globalization;

    using static Part;
    using static HexFormatSpecs;
    using static memory;

    [ApiHost]
    public readonly struct HexNumericParser
    {
        /// <summary>
        /// Attempts to parse a hex string as an unsigned long
        /// </summary>
        /// <param name="src">The source text</param>
        public static ParseResult<ulong> parse64u(string src)
        {
            if(ulong.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out ulong value))
                return root.parsed(src,value);
            else
                return root.unparsed<ulong>(src);
        }

        /// <summary>
        /// Attempts to parse a hex string as an unsigned long
        /// </summary>
        /// <param name="src">The source text</param>
        public static ParseResult<uint> parse32u(string src)
        {
            if(uint.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out uint value))
                return root.parsed(src,value);
            else
                return root.unparsed<uint>(src);
        }

        [Op, Closures(UnsignedInts)]
        public static T parse<T>(string src, T @default)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(U8(src, uint8(@default)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(U16(src, uint16(@default)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(U32(src, uint32(@default)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(U64(src, uint64(@default)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static byte U8(string src, byte @default)
            => byte.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null, out byte value) ? value : @default;

        [MethodImpl(Inline)]
        static ushort U16(string src, ushort @default)
            => ushort.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null, out ushort value) ? value : @default;

        [MethodImpl(Inline)]
        static uint U32(string src, uint @default)
            => uint.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null, out uint value) ? value : @default;

        [MethodImpl(Inline)]
        static ulong U64(string src, ulong @default)
            => ulong.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out ulong value) ? value : @default;
    }
}