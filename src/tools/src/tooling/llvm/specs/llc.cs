//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{

    public partial class llc : CmdBuilder<llc>
    {
        public llc()
            : base(Toolsets.llvm.llc)
        {

        }
    }
}