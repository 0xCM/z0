//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Rules;

    using Z0.Asm;

    [ApiComplete]
    partial struct Msg
    {
        public static MsgPattern<Fence<char>,string> FenceNotFound => "The signature fence {0} for the source expression {1} is not present";

        public static MsgPattern<AsmMnemonic> MonicCodeParseFailed => "No corresponding mnemonic code for {0} was found";

        public static MsgPattern<string> CouldNotParseSigExpr => "Could not created a signature expression from {0}";

    }
}