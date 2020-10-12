//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitPartStrings;
    using static z;

    using F = CliStringRecord.Fields;
    using W = CliStringRecord.RenderWidths;
    using R = CliStringRecord;

    [WfHost]
    public sealed class EmitPartStrings : WfHost<EmitPartStrings>
    {
        public static WfStepId StepId
            => Workflow.step<EmitPartStrings>();

    }

    ref struct EmitPartStringsStep
    {
        /// <summary>
        /// Indicates the number of records emitted after running
        /// </summary>
        public uint EmissionCount;

        readonly IWfShell Wf;

        readonly IPart Part;

        readonly R.Kind StringKind;

        readonly FS.FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmitPartStringsStep(IWfShell wf, IPart part, R.Kind sk, CorrelationToken ct)
        {
            Wf = wf;
            Part = part;
            if(sk == R.Kind.System)
                TargetPath = Wf.Db().Table(part.Id, CliSystemString.TableId, FileKind.Csv);
            else
                TargetPath = Wf.Db().Table(part.Id, CliUserString.TableId, FileKind.Csv);
            StringKind = sk;
            EmissionCount = 0;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        [Op]
        static ref readonly RecordFormatter<F,W> format(in CliSystemString src, in RecordFormatter<F,W> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Source, src.Source);
            dst.Delimit(F.HeapSize, src.HeapSize);
            dst.Delimit(F.Length, src.Length);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Value, src.Content);
            dst.EmitEol();
            return ref dst;
        }

        [Op]
        static ref readonly RecordFormatter<F,W> format(in CliUserString src, in RecordFormatter<F,W> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Source, src.Source);
            dst.Delimit(F.HeapSize, src.HeapSize);
            dst.Delimit(F.Length, src.Length);
            dst.Delimit(F.Offset, src.Offset);
            dst.Delimit(F.Value, src.Content);
            dst.EmitEol();
            return ref dst;
        }

        public void Run()
        {
            Wf.Running(StepId);

            if(StringKind == R.Kind.System)
                ReadSystemStrings();
            else
                ReadUserStrings();

            Wf.EmittedTable<CliSystemString>(StepId, EmissionCount,FS.path(TargetPath.Name));
        }

        void ReadUserStrings()
        {
            var srcPath = Part.PartPath();
            using var reader = PeTableReader.open(srcPath);
            var data = reader.UserStrings();
            EmissionCount = (uint)data.Length;

            var target = Table.formatter<F,W>();
            using var writer = TargetPath.Writer();
            target.EmitHeader();

            for(var i=0u; i<EmissionCount; i++)
                format(skip(data,i), target);
            writer.Write(target.Render());
        }

        void ReadSystemStrings()
        {
            var srcPath = Part.PartPath();
            using var reader = PeTableReader.open(srcPath);
            var data = reader.SystemStrings();
            EmissionCount = (uint)data.Length;

            var target = Table.formatter<F,W>();
            using var writer = TargetPath.Writer();
            target.EmitHeader();

            for(var i=0u; i<EmissionCount; i++)
                format(skip(data,i), target);
            writer.Write(target.Render());
        }
    }
}