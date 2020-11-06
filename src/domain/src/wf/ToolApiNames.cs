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


        const string patterns = nameof(patterns);
    }
}