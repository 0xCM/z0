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
    using D = HexDigit;

    partial struct Hex
    {
        [Op]
        public static bool parse(char src, out byte dst)
        {
            if(HexDigitTest.scalar(src))
            {
                dst = Bytes.sub((byte)src, MinScalarCode);
                return true;
            }
            else if(HexDigitTest.upper(src))
            {
                dst = Bytes.add(Bytes.sub((byte)src, MinCharCodeU), Numeric.u8(0xA));
                return true;
            }
            else if(HexDigitTest.lower(src))
            {
                dst = Bytes.add(Bytes.sub((byte)src,  MinCharCodeL), Numeric.u8(0xa));
                return true;
            }
            else
            {
                dst = 0;
                return false;
            }
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