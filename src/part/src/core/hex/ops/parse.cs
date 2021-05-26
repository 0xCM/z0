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
        const char Zero = (char)0;

        [MethodImpl(Inline), Op]
        public static bool nonzero(char c0, char c1)
            => c0 != Zero && c1 != Zero;

        /// <summary>
        /// Parses a nibble
        /// </summary>
        /// <param name="c">The source character</param>
        [MethodImpl(Inline), Op]
        public static bool parse(char c, out byte dst)
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
        public static uint parse(ReadOnlySpan<char> src, Span<byte> dst)
        {
            var input = src;
            var maxbytes = dst.Length;
            var j=0u;
            var count = src.Length;
            var c0 = Zero;
            var c1 = Zero;
            for(var i=0u; i<count; i++)
            {
                if(j == maxbytes)
                    return j;

                ref readonly var c = ref skip(src,i);
                if(TextQuery.whitespace(c) && nonzero(c0, c1))
                {
                    if(parse(c0, c1, out seek(dst,j)))
                        j++;

                    c0 = Zero;
                    c1 = Zero;
                }
                else
                {
                    if(c0 == Zero)
                        c0 = c;
                    else if(c1 == Zero)
                        c1 = c;
                    else
                    {
                        if(parse(c0, c1, out seek(dst,j)))
                            j++;
                        c0 = Zero;
                        c1 = Zero;
                    }
                }
            }

            if(nonzero(c0, c1) && parse(c0, c1, out seek(dst,j)))
                j++;

            return j;
        }

        [MethodImpl(Inline), Op]
        public static bool parse(char c, out HexDigit dst)
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
    }
}