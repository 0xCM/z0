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

        public void Run()
        {
            Wf.Emitting(StepId, EmissionType, TargetPath);

            var data = ReadData();
            EmissionCount = (uint)data.Length;

            var target = PartRecords.formatter(ImageRecords.Strings);
            using var writer = TargetPath.Writer();
            target.EmitHeader();

            for(var i=0u; i<EmissionCount; i++)
                PartRecords.format(skip(data,i), target);
            writer.Write(target.Render());

            Wf.Emitted(StepId, EmissionType, EmissionCount, TargetPath);
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
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