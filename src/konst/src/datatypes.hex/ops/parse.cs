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
    using static HexCharData;

    partial class Hex
    {
        [MethodImpl(Inline), Op]
        public static bool parse(char src, out byte dst)
        {
            if(HexTest.scalar(src))
            {
                dst = Bytes.sub((byte)src, MinScalarCode);
                return true;
            }
            else if(HexTest.upper(src))
            {
                dst = Bytes.add(Bytes.sub((byte)src, MinCharCodeU), unsigned(0xA));
                return true;
            }
            else if(HexTest.lower(src))
            {
                dst = Bytes.add(Bytes.sub((byte)src,  MinCharCodeL), unsigned(0xA));
                return true;
            }
            else
            {
                dst = 0;
                return false;
            }
        }
    }
}