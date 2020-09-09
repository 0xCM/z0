//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static EmitPartStringsStep;
    using static z;

    using F = ImageStringField;
    using W = ImageStringFieldWidth;


    public enum PartStringKind
    {
        System = 0,

        User = 1,
    }

    public ref struct EmitPartStrings
    {
        /// <summary>
        /// Indicates the number of records emitted after running
        /// </summary>
        public uint EmissionCount;

        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly IPart Part;

        readonly PartStringKind StringKind;

        readonly FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmitPartStrings(IWfShell wf, IPart part, PartStringKind sk, FolderPath dir, CorrelationToken ct)
        {
            Wf = wf;
            Part = part;
            Ct = ct;
            TargetPath = dir + FileName.define(part.Id.Format(), ExtName(sk));
            StringKind = sk;
            EmissionCount = 0;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        [Op]
        static ref readonly RecordFormatter<F,W> format(in ImageStringRecord src, in RecordFormatter<F,W> dst)
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
            Wf.Emitting<ImageStringRecord>(StepId, FS.path(TargetPath.Name));

            var data = ReadData();
            EmissionCount = (uint)data.Length;

            var target = Table.formatter<F,W>();
            using var writer = TargetPath.Writer();
            target.EmitHeader();

            for(var i=0u; i<EmissionCount; i++)
                format(skip(data,i), target);
            writer.Write(target.Render());

            Wf.Emitted<ImageStringRecord>(StepId, EmissionCount,FS.path(TargetPath.Name));
        }

        ReadOnlySpan<ImageStringRecord> ReadData()
            => StringKind == PartStringKind.User ? ReadUserStrings(Part) : ReadSystemStrings(Part);

        ReadOnlySpan<ImageStringRecord> ReadUserStrings(IPart part)
        {
            var srcPath = part.PartPath();
            using var reader = PeTableReader.open(srcPath);
            return reader.ReadUserStrings();
        }

        ReadOnlySpan<ImageStringRecord> ReadSystemStrings(IPart part)
        {
            var srcPath = part.PartPath();
            using var reader = PeTableReader.open(srcPath);
            return reader.ReadStrings();
        }
    }
}