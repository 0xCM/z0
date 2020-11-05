//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct OsCmd
    {
        [ToolCmd(ToolNames.echo)]
        public struct Echo : IToolCmd<Echo>
        {
            public bit On;

            public utf8 Message;
        }
    }
}