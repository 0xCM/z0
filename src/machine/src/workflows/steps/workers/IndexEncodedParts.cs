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

    public ref struct IndexEncodedParts
    {
        public const string ActorName = nameof(IndexEncodedParts);
        
        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        readonly PartFiles SourceFiles;

        public EncodedParts EncodedIndex;
        
        public IndexEncodedParts(IWfContext wf, PartFiles src, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            SourceFiles = src;
            Wf.Created(ActorName, Ct);
            EncodedIndex = default(EncodedParts);
        }

        public void Dispose()
        {
            Wf.Finished(ActorName, Ct);

        }
        
        public void Run()
        {
            Wf.Running(ActorName, Ct);

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
                        Wf.Error(ActorName, $"Parse failed for {path}", Ct);
                    }
                }

                EncodedIndex = builder.Freeze();
                Wf.Raise(new IndexedEncoded(ActorName, EncodedIndex, Ct));            

            }
            catch(Exception e)
            {
                Wf.Error(e, Ct);
            }

            Wf.Ran(ActorName, Ct);
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
                var code = MemberCode.define(src.Uri, src.Data);
                if(!dst.Include(code))
                    Wf.Warn(ActorName, $"Duplicate | {src.Uri.Format()}", Ct);
            }
        }
    }
}