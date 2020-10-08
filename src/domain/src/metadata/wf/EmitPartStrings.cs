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

    using F = ImageStringField;
    using W = ImageStringFieldWidth;


    [WfHost]
    public sealed class EmitPartStrings : WfHost<EmitPartStrings>
    {
        public const string EmissionType = ImageStringRecords.DataType;

        public static WfStepId StepId
            => WfCore.step<EmitPartStrings>();

        public static string ExtName(PartStringKind kind)
            => (kind == PartStringKind.System ? ImageStringRecords.SystemKindExt : ImageStringRecords.UserKindExt).ToLower();
    }

    ref struct EmitPartStringsStep
    {
        /// <summary>
        /// Indicates the number of records emitted after running
        /// </summary>
        public uint EmissionCount;

        readonly IWfShell Wf;

        readonly IPart Part;

        readonly PartStringKind StringKind;

        readonly FS.FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmitPartStringsStep(IWfShell wf, IPart part, PartStringKind sk, FolderPath dir, CorrelationToken ct)
        {
            Wf = wf;
            Part = part;
            if(sk == PartStringKind.System)
                TargetPath = Wf.Paths.Table(SystemStringRecord.TableId, string.Concat(part.Id.Format(), Chars.Dot, SystemStringRecord.DataType));
            else
                TargetPath = Wf.Paths.Table(UserStringRecord.TableId, string.Concat(part.Id.Format(), Chars.Dot, UserStringRecord.DataType));
            StringKind = sk;
            EmissionCount = 0;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        [Op]
        static ref readonly RecordFormatter<F,W> format(in SystemStringRecord src, in RecordFormatter<F,W> dst)
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
        static ref readonly RecordFormatter<F,W> format(in UserStringRecord src, in RecordFormatter<F,W> dst)
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

            if(StringKind == PartStringKind.System)
                ReadSystemStrings();
            else
                ReadUserStrings();

            Wf.EmittedTable<SystemStringRecord>(StepId, EmissionCount,FS.path(TargetPath.Name));
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