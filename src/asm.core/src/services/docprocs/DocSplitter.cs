//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using static core;

    public class DocSplitter : Service<DocSplitter>
    {
        RecordSet<DocSplitSpec> Specs;

        object SpecsLocker;

        DocProcessArchive Docs;

        public DocSplitter()
        {
            Specs = RecordSet<DocSplitSpec>.Empty;
            SpecsLocker = new object();

        }

        protected override void Initialized()
        {
            Docs = new DocProcessArchive(Context.AsmWorkspace().DocRoot());
            var pipe = DocSplitSpecs.Service;
            var outcome = pipe.Load(SpecPath, out Specs);
            if(outcome.Fail)
                Error(outcome.Message);
        }

        public void Run()
        {
            var specs = GetSpecs();
            var buffer = new CBag<LineRange>();
            iter(specs.View, spec => Split(spec, buffer));
        }

        void Split(in DocSplitSpec spec, IReceiver<LineRange> dst)
        {
            var src = RefDocPath(spec.DocId);
            using var reader = src.Reader();
            var counter = 1u;
            var count = spec.LastLine - spec.FirstLine + 1;
            var range = Lines.range(spec.FirstLine, spec.LastLine, alloc<TextLine>(count));
            var lines = range.Edit;
            var i=0;
            var line = reader.ReadLine();
            while(line != null && counter++ <= spec.LastLine && i<count)
            {
                line = reader.ReadLine();
                if(counter >= spec.FirstLine)
                    seek(lines, i++) = Lines.line(counter, line);
            }

            Emit(range, ExtractPath(spec.DocId, spec.Unit));
            dst.Deposit(range);
        }


        void Emit(in LineRange src, FS.FilePath dst)
        {
            var emitting = Emitting(dst);
            using var writer = dst.Writer();
            var data = src.View;
            var count = data.Length;
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(data,i));
            Emitted(emitting, count);
        }

        RecordSet<DocSplitSpec> GetSpecs()
        {
            lock(SpecsLocker)
            {
                if(Specs.IsNonEmpty)
                    return Specs;
                else
                {
                    var pipe = DocSplitSpecs.Service;
                    var outcome = pipe.Load(SpecPath, out Specs);
                    if(outcome.Fail)
                        Error(outcome.Message);
                    return Specs;
                }
            }
        }

        FS.FilePath RefDocPath(string id)
            => Docs.RefDoc(id, FS.Txt);

        FS.FilePath ExtractPath(string id, string unit)
            => Docs.DocExtract(id, unit, FS.Txt);

        FS.FilePath SpecPath
            => Docs.Root + FS.file("splits", FS.Csv);
    }

    partial class XTend
    {
        public static DocSplitter DocSplitter(this IServiceContext context)
            => Z0.DocSplitter.create(context);
    }
}