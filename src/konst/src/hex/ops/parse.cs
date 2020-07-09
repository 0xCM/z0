//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static core;

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
                dst = core.add(core.sub((byte)src, MinCharCodeU), unsigned(0xA));
                return true;
            }
            else if(isLower(src))
            {
                dst = core.add(core.sub((byte)src,  MinCharCodeL), unsigned(0xA));
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