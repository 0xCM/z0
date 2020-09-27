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

    using F = PeHeaderField;

    public readonly ref struct EmitImageHeaders
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IPart[] Parts;

        readonly FilePath TargetPath;

        [MethodImpl(Inline)]
        public EmitImageHeaders(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Parts = Wf.Api.Storage;
            TargetPath = wf.ResourceRoot + FileName.define("z0", "pe.csv");
            Wf.Created(Host, TargetPath);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            var pCount = Parts.Length;
            var total = 0u;
            Wf.Running(Host, pCount);

            var formatter = Formatters.dataset<F>();
            using var writer = TargetPath.Writer();
            writer.WriteLine(formatter.HeaderText);

            foreach(var part in Parts)
            {
                var id = part.Id;
                var assembly = part.Owner;
                var records = PeTableReader.headers(FilePath.Define(assembly.Location));
                var count = (uint)records.Length;

                for(var i=0; i<count; i++)
                {
                    format(z.skip(records,i), formatter);
                    writer.WriteLine(formatter.Render());
                }
                total += count;
            }

            Wf.Ran(Host, delimit(pCount, total));
        }

        static void format(in ImageSectionHeader src, DatasetFormatter<F> dst)
        {
            dst.Delimit(F.FileName, src.File);
            dst.Delimit(F.Section, src.SectionName);
            dst.Delimit(F.Address, src.RawData);
            dst.Delimit(F.Size, src.RawDataSize);
            dst.Delimit(F.EntryPoint, src.EntryPoint);
            dst.Delimit(F.CodeBase, src.CodeBase);
            dst.Delimit(F.Gpt, src.GlobalPointerTable);
            dst.Delimit(F.GptSize, src.GlobalPointerTableSize);
        }
    }
}