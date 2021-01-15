//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    partial struct Llvm
    {
        [Tool]
        public struct TblGen : ITool<TblGen>
        {
            public Name ToolName => ToolNames.tblgen;
        }

        [Cmd]
        public struct TableGenCmd : IToolCmd<TableGenCmd,TblGen>
        {

        }
    }
}