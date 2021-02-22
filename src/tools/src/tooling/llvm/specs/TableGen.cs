//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;

    partial struct Llvm
    {
        [Tool]
        public struct TblGen : ITool<TblGen>
        {
            public ToolId Id => ToolNames.tblgen;
        }

        [Cmd]
        public struct TableGenCmd : IToolCmd<TableGenCmd,TblGen>
        {

        }
    }
}