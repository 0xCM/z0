//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [WfHost]
    public sealed class EmitFieldMetadata : WfHost<EmitFieldMetadata>
    {
        protected override void Execute(IWfRuntime wf)
        {
            wf.ImageDataEmitter().EmitFieldMetadata();
        }
    }
}