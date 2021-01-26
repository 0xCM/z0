//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static HexFormatSpecs;

    using C = AsciChar;

    partial class Hex
    {
        [Op]
        public static bool parse(char src, out byte dst)
        {
            if(HexTest.scalar(src))
            {
                dst = Bytes.sub((byte)src, MinScalarCode);
                return true;
            }
            else if(HexTest.upper(src))
            {
                dst = Bytes.add(Bytes.sub((byte)src, MinCharCodeU), Numeric.unsigned(0xA));
                return true;
            }
            else if(HexTest.lower(src))
            {
                dst = Bytes.add(Bytes.sub((byte)src,  MinCharCodeL), Numeric.unsigned(0xA));
                return true;
            }
            else
            {
                dst = 0;
                return false;
            }
        }

        [Op]
        public static bool parse(AsciChar src, out HexCode dst)
        {
            switch(src)
            {
                case C.d0:
                case C.d1:
                case C.d2:
                case C.d3:
                case C.d4:
                case C.d5:
                case C.d6:
                case C.d7:
                case C.d8:
                case C.d9:
                case C.a:
                case C.b:
                case C.c:
                case C.d:
                case C.e:
                case C.f:
                case C.A:
                case C.B:
                case C.C:
                case C.D:
                case C.E:
                case C.F:
                    dst = (HexCode)src;
                break;
                default:
                    dst = HexCode.None;
                break;

            }

            return dst != HexCode.None;
        }
    }
}