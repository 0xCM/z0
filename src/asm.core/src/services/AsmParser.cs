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
        static Fence<char> SigFence => (LParen, RParen);

        static Fence<char> OpCodeFence => (Lt, Gt);

        static MsgPattern<Count,Count,TextLine> FieldCountMismatch => "Expected {0} fields but found {1} in '{2}'";

        const string Implication = " => ";
    }
}