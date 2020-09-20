//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public ref struct CheckResources
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly FS.FilePath Source;


        [MethodImpl(Inline)]
        public CheckResources(IWfShell wf, WfHost host, FS.FilePath src)
        {
            Wf = wf;
            Host = host;
            Source = src;
            Wf.Created(Host);
        }

        public void Run()
        {
            Wf.Running(Host);
            TryRun();
            Wf.Ran(Host);
        }

        void Execute()
        {
            using var map = MemoryFile.open(Source);
            var @base = map.BaseAddress;
            var sig = map.Read(@base, 2).AsUInt16();
            var magic = Z0.Image.PeLiterals.Magical;
            var info = map.Description.Description;;
            Wf.Status(Host, info);
        }

        void TryRun()
        {
            try
            {
                Execute();
            }
            catch(Exception e)
            {
                Wf.Error(Host, e);
            }
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }
    }
}