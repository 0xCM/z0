//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{

    public partial class llc : ToolCmdBuilder<llc>
    {
        public llc()
            : base(Toolsets.llvm.llc)
        {

        }
    }
}