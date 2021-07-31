//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct asm
    {
        [Op]
        public static AsmHexCode hexcode(string src)
        {
            if(AsmHexCode.parse(src, out var dst))
                return dst;
            else
                return AsmHexCode.Empty;
        }
    }
}