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

    public ref struct EmitImageHeaders
    {
        public readonly IWfShell Wf;

        public readonly EmitImageHeadersHost Host;

        public readonly WfDataFlow<FS.Files, FS.FilePath> Df;

        [MethodImpl(Inline)]
        public EmitImageHeaders(IWfShell wf, EmitImageHeadersHost host, WfDataFlow<FS.Files, FS.FilePath> df)
        {
            Wf = wf;
            Host = host;
            Df = df;
            Wf.Created(Host.Id);
        }

        public void Run()
        {
            Wf.Running(Host.Id);
            TryRun();
            Wf.Ran(Host.Id);
        }

        Outcome<uint> Emit()
        {
            var total = 0u;
            var formatter = Table.rowformatter<ImageSectionHeader>();
            using var writer = Df.Target.Writer();
            writer.WriteLine(formatter.FormatHeader());
            foreach(var file in Df.Source)
            {
                var result = ImageReader.read(file, out Span<ImageSectionHeader> dst);
                if(result)
                {
                    var count = result.Data;
                    Wf.Status(Host.Id, count);

                    for(var i=0u; i<count; i++)
                        writer.WriteLine(formatter.FormatRow(skip(dst,i)));
                    total += count;
                }

            }
            return total;
        }

        Outcome<uint> TryRun()
        {
            try
            {
                return Emit();
            }
            catch(Exception e)
            {
                Wf.Error(Host.Id, e);
                return e;
            }
        }

        public void Dispose()
        {
            Wf.Disposed(Host.Id);
        }
    }
}