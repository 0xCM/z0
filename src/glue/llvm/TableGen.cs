//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct Llvm
    {
        [Tool]
        public struct TblGen : ITool<TblGen>
        {
            public ToolId Id => Toolspace.llvm_tblgen;
        }

        [Cmd]
        public struct TableGenCmd : IToolCmd<TableGenCmd,TblGen>
        {

        }
    }
}