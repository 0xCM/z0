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
    using static z;

    public readonly struct HexNumericParser
    {
        /// <summary>
        /// Attempts to parse a hex string as an unsigned long
        /// </summary>
        /// <param name="src">The source text</param>
        public static ParseResult<ulong> parse(string src)
        {
            if(ulong.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out ulong value))
                return parsed(src,value);
            else
                return unparsed<ulong>(src);
        }

        public static HexNumericParser Service
            => default(HexNumericParser);

        [MethodImpl(Inline)]
        public T Parse<T>(string src, T @default)
            => Parse<T>(src).ValueOrDefault(@default);

        [MethodImpl(Inline)]
        public ParseResult<T> Parse<T>(string src)
        {
            if(typeof(T) == typeof(byte))
                return U8(src).As<T>();
            else if(typeof(T) == typeof(ushort))
                return U16(src).As<T>();
            else if(typeof(T) == typeof(uint))
                return U32(src).As<T>();
            else if(typeof(T) == typeof(ulong))
                return U64(src).As<T>();
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static ParseResult<byte> U8(string src)
        {
            if(byte.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null, out byte value))
                return ParseResult.Success(src, value);
            else
                return ParseResult.Fail<byte>(src);
        }

        [MethodImpl(Inline)]
        static ParseResult<ushort> U16(string src)
        {
            if(ushort.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null, out ushort value))
                return ParseResult.Success(src, value);
            else
                return ParseResult.Fail<ushort>(src);
        }

        [MethodImpl(Inline)]
        static ParseResult<uint> U32(string src)
        {
            if(uint.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null, out uint value))
                return ParseResult.Success(src, value);
            else
                return ParseResult.Fail<uint>(src);
        }

        [MethodImpl(Inline)]
        static ParseResult<ulong> U64(string src)
        {
            if(ulong.TryParse(ClearSpecs(src), NumberStyles.HexNumber, null,  out ulong value))
                return ParseResult.Success(src, value);
            else
                return ParseResult.Fail<ulong>(src);
        }
    }
}