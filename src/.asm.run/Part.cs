//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmRun)]

namespace Z0.Parts
{
    using System;

    public sealed class AsmRun : Part<AsmRun>
    {

    }
}

namespace Z0
{
    readonly struct Shell
    {
        public const PartId ShellId = PartId.Run;

        public const string ShellName = nameof(PartId.Run) + "/" + nameof(Shell);
    }
}