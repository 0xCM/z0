//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmParser
    {
        public static Outcome parse(string src, out AsmOffsetLabel dst)
        {
            dst = default;
            var result = DataParser.parse(src, out Hex64 value);
            if(result)
                dst = asm.label(Bits.effwidth(value), value);
            return result;
        }

        public static Outcome parse(AsmBlockLabel src, out AsmOffsetLabel dst)
            => parse(src.Name, out dst);
    }
}