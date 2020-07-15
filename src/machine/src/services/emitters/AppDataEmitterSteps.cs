//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Z0.Asm;

    public readonly struct AppDataEmitterSteps : IWorkflowSteps<AppDataEmitterSteps>
    {
        public EmitResBytes EmitResBytes => default;
    }
}