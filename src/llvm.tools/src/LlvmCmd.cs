//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    public sealed partial class LlvmCmd : AppCmdService<LlvmCmd>
    {
        llvm.EtlWorkflow LlvmEtl;

        protected override void Initialized()
        {
            LlvmEtl = Wf.LlvmEtl();
        }
    }
}