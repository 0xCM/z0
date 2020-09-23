//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;


    public ref struct EmitRenderPatterns
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        public DataFlow<Type,FS.FilePath> Df;

        [MethodImpl(Inline)]
        public EmitRenderPatterns(IWfShell wf, WfHost host, DataFlow<Type,FS.FilePath> df)
        {
            Wf = wf;
            Host = host;
            Df = df;
            Wf.Created(Host);
        }

        public void Run()
        {
            Wf.Running(Host);

            try
            {
                var patterns = Render.sources(Df.Source);
                foreach(var pattern in patterns.View)
                    Wf.Status(Host, pattern.Format());

            }
            catch(Exception e)
            {
                Wf.Error(Host,e);
            }

            Wf.Ran(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}