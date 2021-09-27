//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;

    public sealed partial class LlvmCmd : AppCmdService<LlvmCmd>
    {
        EtlWorkflow LlvmEtl;

        LlvmToolbase Toolbase;

        protected override void Initialized()
        {
            LlvmEtl = Wf.LlvmEtl();
            Toolbase = Wf.LLvmToolbase();
        }
    }
}