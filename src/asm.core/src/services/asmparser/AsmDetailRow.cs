//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial struct AsmParser
    {
        public static Outcome parse(TextRow src, out AsmDetailRow dst)
        {
            var input = src.Cells;
            var i = 0;
            var outcome = Outcome.Empty;
            dst = default;
            outcome = DataParser.parse(skip(input, i++), out dst.Sequence);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.BlockAddress);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.IP);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.GlobalOffset);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.LocalOffset);
            if(!outcome)
                return outcome;

            dst.Mnemonic = new AsmMnemonic(skip(input, i++));

            outcome = parse(skip(input, i++), out dst.OpCode);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.Instruction);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.Statement);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.Encoded);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.CpuId);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.OpCodeId);
            if(!outcome)
                return outcome;
            return true;
        }
    }
}
