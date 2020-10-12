//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [LiteralProvider]
    public readonly struct ToolFolderNames
    {
        public const string input = nameof(input);

        public const string output = nameof(output);

        public const string processed = nameof(processed);
    }
}