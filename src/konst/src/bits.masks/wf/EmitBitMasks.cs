//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public ref struct EmitBitMasks
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        public readonly FS.FilePath TargetPath;

        public Count EmissionCount;

        [MethodImpl(Inline)]
        public EmitBitMasks(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            EmissionCount = 0;
            TargetPath = FS.path((Wf.IndexRoot + FileName.define("bitmasks", FileExtensions.Csv)).Name);
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Running(Host, TargetPath);
            EmissionCount = BitMasks.emit(TargetPath);
            Wf.Ran(Host, delimit(EmissionCount, TargetPath));
        }
    }
}