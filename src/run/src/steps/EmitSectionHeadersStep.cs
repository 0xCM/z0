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

    public ref struct EmitSectionHeadersStep
    {
        public readonly IWfShell Wf;

        public readonly WfHost Host;

        public FS.Files Source;

        public FS.FilePath Target;

        [MethodImpl(Inline)]
        public EmitSectionHeadersStep(IWfShell wf, WfHost host, FS.Files src, FS.FilePath dst)
        {
            Wf = wf;
            Host = host;
            Source = src;
            Target = dst;
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
            var formatter = TableRows.formatter<ImageSectionHeader>(ImageSectionHeader.RenderWidths);
            using var writer = Target.Writer();
            writer.WriteLine(formatter.FormatHeader());
            foreach(var file in Source)
            {
                var result = ImageReader.read(file, out Span<ImageSectionHeader> dst);
                if(result)
                {
                    var count = result.Data;

                    for(var i=0u; i<count; i++)
                    {
                        ref readonly var row = ref skip(dst,i);
                        writer.WriteLine(formatter.FormatRow(skip(dst,i)));
                    }

                    total += count;

                    Wf.Status(Host.Id, file);
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