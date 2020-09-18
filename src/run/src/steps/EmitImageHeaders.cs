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

    public struct ImageHeaderEmitted : ITextual
    {
        public const string FormatPattern = "{0,10} | {1,-80}";

        public FS.FilePath Source;

        public Name Section;

        public static ImageHeaderEmitted define(in ImageSectionHeader src)
        {
            var dst = new ImageHeaderEmitted();
            return dst;
        }

        public string Format()
            => text.format(FormatPattern, Source, Section);
    }

    public ref struct EmitImageHeaders
    {
        public readonly IWfShell Wf;

        public readonly EmitImageHeadersHost Host;

        public readonly DataFlow<FS.Files, FS.FilePath> Df;

        [MethodImpl(Inline)]
        public EmitImageHeaders(IWfShell wf, EmitImageHeadersHost host, DataFlow<FS.Files, FS.FilePath> df)
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