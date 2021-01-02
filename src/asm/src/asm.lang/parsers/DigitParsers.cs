//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using C = AsciChar;

    [ApiHost]
    public readonly struct DigitParsers
    {
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