//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static AsciCharText;

    public partial struct DumpBin
    {
        [LiteralProvider]
        public readonly struct Expressions
        {
            [StringLiteral("dumpbin /HEADERS /OUT:{1} {0}")]
            const string HeadersLiteral = ToolName + Space
                + FlagPrefix + nameof(Flag.HEADERS) + Space
                + FlagPrefix + nameof(Flag.OUT) + FlagDelimiter + RP.Slot1 + Space
                + RP.Slot0;

            public static CmdExpr Headers => HeadersLiteral;
        }
    }
}