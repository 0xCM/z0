//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [LiteralProvider]
    public readonly struct DbPartitionNames
    {
        public const string Docs = "docs";

        public const string Tables = "tables";

        public const string Sources = "sources";

        public const string Stage = "stage";

        public const string Tools = "tools";
    }
}