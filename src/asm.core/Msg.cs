//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    using Z0.Asm;

    using static Rules;

    [ApiComplete]
    struct Msg
    {
        public static MsgPattern<AsmMnemonic> MonicCodeParseFailed => "Attempt to parse mnemonic code for {0} failed";

        public static MsgPattern<string> CouldNotParseSigExpr => "Could not created a signature expression from {0}";

        public static MsgPattern<Count,Count> UnexpectedFieldCount => "{0} fields were expected and yet {1} were found";

        public static MsgPattern<FS.FileUri> CouldNotParseDocument => "Could not parse {0}";

        public static MsgPattern<TextRow,string> CouldNotParseStatementRow => "Could not parse statement from {0}: {1}";

        public static MsgPattern<Fence<char>> OpCodeFenceNotFound => "Op code fence {0} not found";

        public static MsgPattern<Count,Count> CollectedThumbprints => "Collected {0} distinct thumbprints from {1} statements";
    }
}