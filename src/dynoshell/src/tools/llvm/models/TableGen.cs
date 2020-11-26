//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    partial struct Llvm
    {
        public struct TableGen : IToolCmd<TableGen>
        {
            public ToolId ToolId => ToolNames.tblgen;
        }
    }
}