//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct FS
    {
        [LiteralProvider]
        public readonly struct CommonFileNames
        {
            public const string JsonConfig = "config.json";
        }
    }
}
