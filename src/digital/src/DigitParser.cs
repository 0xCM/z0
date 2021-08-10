//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using D = DecimalDigitFacets;
    using O = OctalDigitFacets;
    using B = BinaryDigitFacets;
    using NB = NumericBaseKind;

    [ApiHost]
    public readonly struct DigitParser
    {
        [Op]
        public static bool digit(NB @base, char c, out byte dst)
        {
            dst = byte.MaxValue;
            switch(@base)
            {
                case NB.Base2:
                if(digit(@base2, c, out var d2))
                {
                    dst = (byte)d2;
                    return true;
                }
                break;
                case NB.Base8:
                if(digit(@base8, c, out var d8))
                {
                    dst = (byte)d8;
                    return true;
                }
                break;
                case NB.Base10:
                if(digit(@base10, c, out var d10))
                {
                    dst = (byte)d10;
                    return true;
                }
                break;
                case NB.Base16:
                if(digit(@base16, c, out var d16))
                {
                    dst = (byte)d16;
                    return true;
                }
                break;
            }
            return false;
        }

        [MethodImpl(Inline), Op]
        public static bool digit(Base2 @base, char c, out BinaryDigitValue dst)
        {
            if(Digital.test(@base, c))
            {
                dst = (BinaryDigitValue)((BinaryDigitCode)c - B.MinCode);
                return true;
            }
            else
            {
                dst = (BinaryDigitValue)0xFF;
                return true;
            }
        }

        [MethodImpl(Inline), Op]
        public static bool digit(Base8 @base, char c,  out OctalDigitValue dst)
        {
            if(Digital.test(@base, c))
            {
                dst = (OctalDigitValue)((OctalDigitCode)c - O.MinCode);
                return true;
            }
            else
            {
                dst = (OctalDigitValue)0xFF;
                return true;
            }
        }

        [MethodImpl(Inline), Op]
        public static bool digit(Base10 @base, char c, out DecimalDigitValue dst)
        {
            if(Digital.test(@base, c))
            {
                dst = (DecimalDigitValue)((DecimalDigitCode)c - D.MinCode);
                return true;
            }
            else
            {
                dst = (DecimalDigitValue)0xFF;
                return true;
            }
        }

        [MethodImpl(Inline), Op]
        public static bool digit(Base16 @base, char c, out HexDigitValue dst)
            => Hex.parse(c, out dst);
    }
}