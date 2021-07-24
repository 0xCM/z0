//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Rules;
    using static Chars;

    [ApiHost]
    public readonly partial struct AsmParser
    {
        [Op]
        public static Outcome opcode(string src, out AsmOpCodeExpr dst)
        {
            dst = new AsmOpCodeExpr(src);
            return true;
        }

        public static Outcome parse(string src, out AsmOpCodeExpr dst)
        {
            dst = asm.opcode(src);
            return true;
        }

        public static Outcome parse(string src, out AsmOffsetLabel dst)
        {
            dst = default;
            var result = DataParser.parse(src, out Hex64 value);
            if(result)
            {
                var effective = Bits.effwidth(value);
                dst = asm.label(effective, value);
            }
            return result;
        }

        public static Outcome parse(AsmLabel src, out AsmOffsetLabel dst)
            => parse(src.Format(), out dst);

        static Fence<char> SigFence => (LParen, RParen);

        static Fence<char> OpCodeFence => (Lt, Gt);

        static MsgPattern<Count,Count,TextLine> FieldCountMismatch => "Expected {0} fields but found {1} in '{2}'";

        const string Implication = " => ";
    }
}