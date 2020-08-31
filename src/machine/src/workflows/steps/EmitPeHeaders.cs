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
    using static EmitPeHeadersStep;

    using F = PeHeaderField;

    public readonly ref struct EmitPeHeaders
    {
        readonly IWfShell Wf;

        readonly IPart[] Parts;

        readonly FilePath TargetPath;

        readonly CorrelationToken Ct;

        [MethodImpl(Inline)]
        public EmitPeHeaders(IWfShell wf, IPart[] src, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Parts = src;
            TargetPath = wf.ResourceRoot + FileName.define("z0", "pe.csv");
            Wf.Created(StepId, TargetPath);
        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }

        public void Run()
        {
            var pCount = Parts.Length;
            var total = 0u;
            Wf.Running(StepId, pCount);

            var formatter = Formatters.dataset<F>();
            using var writer = TargetPath.Writer();
            writer.WriteLine(formatter.HeaderText);

            foreach(var part in Parts)
            {
                var id = part.Id;
                var assembly = part.Owner;
                var records = PeMetaReader.headers(FilePath.Define(assembly.Location));
                var count = (uint)records.Length;

                for(var i=0; i<count; i++)
                {
                    format(z.skip(records,i), formatter);
                    writer.WriteLine(formatter.Render());
                }
                total += count;
            }

            Wf.Ran(StepId, delimit(pCount, total));
        }

        static void format(in PeHeaderRecord src, DatasetFormatter<F> dst)
        {
            dst.Append(F.FileName, src.FileName);
            dst.Delimit(F.Section, src.Section);
            dst.Delimit(F.Address, src.Address);
            dst.Delimit(F.Size, src.Size);
            dst.Delimit(F.EntryPoint, src.EntryPoint);
            dst.Delimit(F.CodeBase, src.CodeBase);
            dst.Delimit(F.Gpt, src.GlobalPointerTable);
            dst.Delimit(F.GptSize, src.GlobalPointerTableSize);
        }
    }
}