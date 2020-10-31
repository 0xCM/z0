//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    using static ApiNameParts;
    using static ToolNames;

    public readonly struct ToolApiNames
    {
        public const string Dumpbin = tools + dot + dumpbin;

        public const string DumpbinPatterns = tools + dot + dumpbin + dot + patterns;

        const string patterns = nameof(patterns);
    }
}