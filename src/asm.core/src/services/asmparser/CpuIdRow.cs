//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial struct AsmParser
    {
        public static Outcome parse(TextRow src, out CpuIdRow dst)
        {
            var input = src.Cells;
            var i = 0;
            var outcome = Outcome.Success;
            outcome += DataParser.parse(skip(input,i++), out dst.Chip);
            outcome += DataParser.parse(skip(input,i++), out dst.Leaf);
            outcome += DataParser.parse(skip(input,i++), out dst.Subleaf);
            outcome += DataParser.parse(skip(input,i++), out dst.Eax);
            outcome += DataParser.parse(skip(input,i++), out dst.Ebx);
            outcome += DataParser.parse(skip(input,i++), out dst.Ecx);
            outcome += DataParser.parse(skip(input,i++), out dst.Edx);
            return outcome;
        }
    }
}
