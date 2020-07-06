//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;
    using static HexSpecs;

    partial class Hex
    {
        [MethodImpl(Inline), Op]
        public static bool parse(char src, out byte dst)
        {            
            if(isNumber(src))
            {
                dst = core.sub((byte)src, MinScalarCode);
                return true;
            }
            else if(isUpper(src))
            {
                dst = (byte)((byte)src - MinCharCodeU + 0xA);
                return true;
            }
            else if(isLower(src))
            {
                dst = (byte)((byte)src - MinCharCodeL + 0xA);
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
