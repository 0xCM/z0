//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [WfHost(CommandName)]
    public sealed class EmitImageHeaders : WfHost<EmitImageHeaders>
    {
        public const string CommandName = nameof(EmitImageHeaders);

        FS.Files Source;

        FS.FilePath Target;

        public static EmitImageHeaders create(FS.Files src, FS.FilePath dst)
        {
            var host = create();
            host.Source = src;
            host.Target = dst;
            return host;
        }

        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitSectionHeadersStep(wf, this, Source,Target);
            step.Run();
        }
    }
}