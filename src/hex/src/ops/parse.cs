//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static HexFormatSpecs;

    using X = HexDigitFacets;
    using C = AsciChar;
    using D = HexDigit;

    partial struct Hex
    {
        /// <summary>
        /// Parses a nibble
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline), Op]
        public static bool parse(AsciCode c, out byte dst)
        {
            if(scalar(c))
            {
                dst = (byte)((byte)c - MinScalarCode);
                return true;
            }
            else if(upper(c))
            {
                dst = (byte)((byte)c - MinCharCodeU + 0xA);
                return true;
            }
            else if(lower(c))
            {
                dst = (byte)((byte)c - MinCharCodeL + 0xa);
                return true;
            }
            dst = byte.MaxValue;
            return false;
        }

        /// <summary>
        /// Parses a nibble
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline), Op]
        public static bool parse(char c, out byte dst)
            => parse((AsciCode)c, out dst);

        [MethodImpl(Inline), Op]
        public static bool parse(char c0, char c1, out byte dst)
        {
            if(parse(c0, out byte d0) && parse(c1, out byte d1))
            {
                dst = (byte)((d0 << 4) | d1);
                return true;
            }
            dst = 0;
            return false;
        }

        [Op]
        public static Outcome<uint> parse(ReadOnlySpan<char> src, Span<byte> dst)
        {
            var counter = 0u;
            var count = src.Length;
            ref var target = ref first(dst);
            var hi = byte.MaxValue;
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                if(whitespace(c) || specifier(c))
                    continue;

                if(parse(c, out HexDigit d))
                {
                    if(hi == byte.MaxValue)
                        hi = (byte)d;
                    else
                    {
                        var lo = (byte)d;
                        seek(target, counter++) = Bytes.or(Bytes.sll(hi,4), lo);
                        hi = byte.MaxValue;
                    }
                }
                else
                    return false;
            }
            return (true,counter);
        }

        public static Outcome parse(ReadOnlySpan<AsciCode> src, out ulong dst)
        {
            dst = 0;
            return parse(src, bytes(dst));
        }

        public static Outcome parse(ReadOnlySpan<char> src, out ulong dst)
        {
            dst = 0;
            return parse(src, bytes(dst));
        }

        [Op]
        public static Outcome<uint> parse(ReadOnlySpan<AsciCode> src, Span<byte> dst)
        {
            var counter = 0u;
            var count = src.Length;
            ref var target = ref first(dst);
            var hi = byte.MaxValue;
            var lo = byte.MaxValue;
            for(var i=count-1; i>=0; i--)
            {
                ref readonly var c = ref skip(src,i);
                if(whitespace(c) || specifier(c))
                    continue;

                if(parse(c, out HexDigit d))
                {
                    if(lo == byte.MaxValue)
                        lo = (byte)d;
                    else
                    {
                        hi = (byte)d;
                        seek(target, counter++) = Bytes.or(Bytes.sll(hi,4), lo);
                        hi = byte.MaxValue;
                        lo = byte.MaxValue;
                    }
                }
                else
                    return false;
            }
            return (true, counter);
        }

        [MethodImpl(Inline), Op]
        public static bool parse(AsciCode c, out HexDigit dst)
        {
            if(scalar(c))
            {
                dst = (HexDigit)((HexCode)c - X.MinScalarCode);
                return true;
            }
            else if(upper(c))
            {
                dst = (HexDigit)((HexCode)c - X.MinLetterCodeU + 0xA);
                return true;
            }
            else if(lower(c))
            {
                dst = (HexDigit)((HexCode)c - X.MinLetterCodeL + 0xa);
                return true;
            }
            dst = (HexDigit)byte.MaxValue;
            return false;
        }

        [MethodImpl(Inline), Op]
        public static bool parse(char c, out HexDigit dst)
            => parse((AsciCode)c, out dst);

        [Op]
        public static bool parse(AsciChar src, out HexDigit dst)
        {
            switch(src)
            {
                case C.d0:
                    dst = D.x0;
                    break;
                case C.d1:
                    dst = D.x1;
                    break;
                case C.d2:
                    dst = D.x2;
                    break;
                case C.d3:
                    dst = D.x3;
                    break;
                case C.d4:
                    dst = D.x4;
                    break;
                case C.d5:
                    dst = D.x5;
                    break;
                case C.d6:
                    dst = D.x6;
                    break;
                case C.d7:
                    dst = D.x7;
                    break;
                case C.d8:
                    dst = D.x8;
                    break;
                case C.d9:
                    dst = D.x9;
                    break;
                case C.a:
                case C.A:
                    dst = D.A;
                    break;
                case C.b:
                case C.B:
                    dst = D.B;
                    break;
                case C.c:
                case C.C:
                    dst = D.C;
                    break;
                case C.d:
                case C.D:
                    dst = D.D;
                    break;
                case C.e:
                case C.E:
                    dst = D.E;
                    break;
                case C.f:
                case C.F:
                    dst = D.F;
                break;
                default:
                    dst = 0;
                    return false;
            }

            return true;
        }

        [MethodImpl(Inline)]
        static bit contains(ReadOnlySpan<AsciCode> src, AsciCode match)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                if(match == skip(src,i))
                    return 1;
            return 0;
        }

        [MethodImpl(Inline)]
        static bit whitespace(AsciCode src)
            => contains(AsciCodes.whitespace(), src);

        [MethodImpl(Inline)]
        static bit whitespace(char src)
            => whitespace((AsciCode)src);
    }
}