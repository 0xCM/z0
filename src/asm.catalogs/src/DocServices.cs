//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    public class DocServices : AppService<DocServices>
    {
        DocProcessArchive Docs;

        public DocServices()
        {
        }

        protected override void Initialized()
        {
            Docs = new DocProcessArchive(Wf.AsmWorkspace().DocRoot());
        }

        public void Split(FS.FilePath specpath)
        {
            var specs = LoadSplitSpecs(specpath);
            var buffer = new CBag<LineRange>();
            iter(specs, spec => Split(spec, buffer));
        }

        public Outcome VerifyLinedDoc(FS.FilePath src)
        {
            var outcome = Outcome.Success;
            using var reader = src.LineReader();
            var counter = 1u;
            while(reader.Next(out var line))
            {
                if(counter != line.LineNumber)
                {
                    outcome = (false, string.Format("{0} != {1}:{2}", counter, line.LineNumber, line.Content));
                    break;
                }
                counter++;
            }
            return outcome;
        }

        public ReadOnlySpan<DocSplitSpec> LoadSplitSpecs(FS.FilePath src)
        {
            var pipe = DocSplitSpecs.Service;
            var outcome = pipe.Load(src, out var specs);
            if(outcome.Fail)
                Wf.Error(outcome.Message);
            return specs;
        }

        public void CombineDocs(ReadOnlySpan<FS.FilePath> src, FS.FilePath dst)
        {
            var count = src.Length;
            var flow = Wf.EmittingFile(dst);
            var counter = 0u;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(src,i);
                if(!input.Exists)
                {
                    Wf.Error(FS.Msg.DoesNotExist.Format(input));
                    return;
                }

                var processing = Wf.Running(string.Format("Appending {0} to {1}", input.ToUri(), dst.ToUri()));
                using var reader = input.Reader();
                var line = reader.ReadLine();
                while(line != null)
                {
                    writer.WriteLine(line);
                    counter++;
                    line = reader.ReadLine();
                }
                Wf.Ran(processing);
            }
            Wf.EmittedFile(flow,counter);
        }

        public bool CreateLinedDoc(FS.FilePath src, FS.FilePath dst)
        {
            var flow = Wf.Running(string.Format("{0} => {1}", src.ToUri(), dst.ToUri()));
            using var reader = src.LineReader();
            using var writer = dst.Writer();
            var counter = 1u;
            while(reader.Next(out var line))
            {
                if(counter != line.LineNumber)
                {
                    var msg = string.Format("{0} != {1}:{2}", counter, line.LineNumber, line.Content);
                    Wf.Error(msg);
                    return false;
                }
                writer.WriteLine(line);
                counter++;
            }
            Wf.Ran(flow,  string.Format("Emitted {0} lines", counter - 1));
            return true;
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
            var emitting = Wf.EmittingFile(dst);
            using var writer = dst.Writer();
            var data = src.View;
            var count = data.Length;
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(data,i));
            Wf.EmittedFile(emitting, count);
        }


        FS.FilePath RefDocPath(string id)
            => Docs.RefDoc(id, FS.Txt);

        FS.FilePath ExtractPath(string id, string unit)
            => Docs.DocExtract(id, unit, FS.Txt);

    }
}