//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;

    [WfHost(CommandName)]
    public sealed class EmitEnums : WfHost<EmitEnums,ClrAssembly>
    {
        public const string CommandName = nameof(EmitEnums);

        protected override void Execute(IWfShell wf, in ClrAssembly src)
        {
            using var step = new EmitEnumsStep(wf, this, src);
            step.Run();
        }
    }
}