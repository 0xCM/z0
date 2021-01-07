//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [WfHost]
    public sealed class EmitBitMasks : WfHost<EmitBitMasks>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitBitMasksStep(wf, this);
            step.Run();
        }
    }

    public ref struct EmitBitMasksStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        public readonly FS.FilePath TargetPath;

        readonly Type TableType;

        [MethodImpl(Inline)]
        public EmitBitMasksStep(IWfShell wf, WfHost host)
        {
            Host = host;
            Wf = wf.WithHost(host);
            TableType = typeof(BitMaskInfo);
            TargetPath = wf.Db().IndexTable(TableType);
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            Wf.EmittingTable(TableType, TargetPath);
            var count = emit(TargetPath);
            Wf.EmittedTable(TableType, count, TargetPath);
        }

        static uint emit(FS.FilePath dst)
            => emit(typeof(BitMasks.Literals), dst);

        static uint emit(Type src, FS.FilePath dst)
        {
            var records = @readonly(ApiQuery.bitmasks(src));
            var count = records.Length;
            var f = BitMasks.formatter();
            using var writer = dst.Writer();
            writer.WriteLine(f.HeaderText);
            for(var i=0u; i<count; i++)
                writer.WriteLine(f.Format(skip(records,i)));
            return (uint)count;
        }
    }
}