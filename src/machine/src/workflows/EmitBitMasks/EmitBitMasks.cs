//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitBitMasksStep;
    using static z;

    public ref struct EmitBitMasks
    {
        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmitBitMasks(IWfShell context, CorrelationToken ct)
        {
            Wf = context;
            Ct = ct;
            TargetPath = Wf.IndexRoot + FileName.define("bitmasks", FileExtensions.Csv);;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId, text.format(RunningPattern, TargetPath));
            var count = BitMasks.emit(FS.path(TargetPath.Name));
            Wf.Ran(StepId, text.format(RanPattern, count, TargetPath));
        }
    }
}