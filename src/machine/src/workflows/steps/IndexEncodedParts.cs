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

    using static IndexEncodedPartsStep;

    public ref struct IndexEncodedParts
    {
        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        readonly PartFiles SourceFiles;

        public EncodedParts EncodedIndex;

        public IndexEncodedParts(IWfContext wf, PartFiles src, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            SourceFiles = src;
            Wf.Created(StepName, Ct);
            EncodedIndex = default(EncodedParts);
        }

        public void Dispose()
        {
            Wf.Finished(StepName, Ct);
        }

        public void Run()
        {
            Wf.Running(StepName, Ct);

            try
            {
                var parser = ParseReportParser.Service;
                var files = span(SourceFiles.ParseFiles);
                var count = files.Length;

                var builder = Encoded.builder();
                for(var i=0; i<count; i++)
                {
                    ref readonly var path = ref skip(files,i);
                    var parsed = parser.Parse(path);
                    if(parsed)
                    {
                        Index(parsed.Value,builder);
                    }
                    else
                    {
                        Wf.Error(StepName, $"Parse failed for {path}", Ct);
                    }
                }

                EncodedIndex = builder.Freeze();
                Wf.Raise(new IndexedEncoded(StepName, EncodedIndex, Ct));

            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }

            Wf.Ran(StepName, Ct);
        }

        void Index(MemberParseReport report, EncodedPartBuilder dst)
        {
            var count = report.RecordCount;
            var view = @readonly(report.Records);
            for(var i=0; i<count; i++)
                Index(skip(view,i), dst);
        }

        void Index(MemberParseRecord src, EncodedPartBuilder dst)
        {
            if(src.Address.IsEmpty)
                Wf.Raise(new Unaddressed(src.Uri, src.Data));
            else
            {
                var code = new X86ApiCode(src.Uri, src.Data);
                if(!dst.Include(code))
                    Wf.Warn(StepId, $"Duplicate | {src.Uri.Format()}");
            }
        }
    }
}