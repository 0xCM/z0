//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public sealed class EmitRenderPatterns : WfHost<EmitRenderPatterns>
    {
        Type Source;

        FS.FilePath Target;

        public static WfHost create(Type src, FS.FilePath dst)
        {
            var host = create();
            host.Source = src;
            host.Target = dst;
            return host;
        }

        protected override void Execute(IWfShell wf)
        {
            using  var step = new EmitRenderPatternsStep(wf, this, Source, Target);
            step.Run();
        }
    }

    public ref struct EmitRenderPatternsStep
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        public Type Source;

        public FS.FilePath Target;

        [MethodImpl(Inline)]
        public EmitRenderPatternsStep(IWfShell wf, WfHost host, Type src, FS.FilePath dst)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Source = src;
            Target = dst;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            Wf.Running();

            try
            {
                var patterns = Render.sources(Source);
                foreach(var pattern in patterns.View)
                    Wf.Status(pattern.Format());

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }

            Wf.Ran();
        }
    }
}