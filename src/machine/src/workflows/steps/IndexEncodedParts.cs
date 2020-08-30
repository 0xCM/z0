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

        public EncodedPartIndex EncodedIndex;

        public IndexEncodedParts(IWfContext wf, PartFiles src, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            SourceFiles = src;
            EncodedIndex = default;
            Wf.Created(StepId);
        }

        public void Dispose()
        {
            Wf.Finished(StepId, Ct);
        }

        public void Run()
        {
            Wf.Running(StepId);

            try
            {
                var files = span(SourceFiles.ParseFiles);
                var count = files.Length;
                var builder = Encoded.builder();

                Wf.Status(StepId, text.format("Indexing {0} datasets",count));

                for(var i=0; i<count; i++)
                {
                    ref readonly var path = ref skip(files,i);

                    var result = MemberParseRecord.load(path);
                    if(result)
                    {
                        Index(result.Value, builder);
                        Wf.Status(StepId, text.format("Indexed {0}", path));
                    }
                    else
                        Wf.Error(StepId, $"Could not parse {path}");
                }

                var status = builder.Status();
                Wf.Status(StepId, text.format("Freeze: {0}", status.Format()));

                EncodedIndex = builder.Freeze();
                Wf.Raise(new IndexedEncodedParts(StepName, EncodedIndex, Ct));

            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }

            Wf.Ran(StepId);
        }

        void Index(ReadOnlySpan<MemberParseRecord> src, EncodedPartBuilder dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                Index(skip(src,i), dst);
        }

        void Index(in MemberParseRecord src, EncodedPartBuilder dst)
        {
            if(src.Address.IsEmpty)
                return;

            var code = new X86ApiCode(src.Uri, src.Data);
            if(!dst.Include(code))
                Wf.Warn(StepId, $"Duplicate | {src.Uri.Format()}");
        }
    }
}