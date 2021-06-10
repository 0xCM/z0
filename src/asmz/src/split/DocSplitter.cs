//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static core;
    using static Root;

    public ref struct CharMap
    {
        public ReadOnlySpan<char> Output;

        public ref readonly char this[char c]
        {
            [MethodImpl(Inline)]
            get => ref skip(Output, (ushort)c);
        }
    }

    public ref struct CharMapper
    {
        readonly CharMap Spec;

        public CharMapper(CharMap spec)
        {
            Spec = spec;
        }

        public uint Map(ReadOnlySpan<char> src, Span<char> dst)
        {
            return 0;
        }

    }

    public class DocSplitter : Service<DocSplitter>
    {
        AsmWorkspace Workspace;

        RecordSet<SplitSpec> Specs;

        object SpecsLocker;

        public DocSplitter()
        {
            Specs = RecordSet<SplitSpec>.Empty;
            SpecsLocker = new object();
        }

        protected override void Initialized()
        {
            Workspace = Context.AsmWorkspace();
            var pipe = SplitSpecPipe.Service;
            var outcome = pipe.Load(SpecPath, out Specs);
            if(outcome.Fail)
            {
                Error(outcome.Message);
            }
        }

        public void Run()
        {
            var specs = GetSpecs();
            var buffer = new CBag<LineRange>();
            iter(specs.View, spec => Split(spec, buffer));
        }

        void Split(in SplitSpec spec, IReceiver<LineRange> dst)
        {
            var src = RefDocPath(spec.DocId);
            using var reader = src.Reader();
            var counter = 1u;
            var count = spec.LastLine - spec.FirstLine + 1;
            var range = TextLines.range(spec.FirstLine, spec.LastLine, alloc<TextLine>(count));
            var lines = range.Edit;
            var i=0;
            var line = reader.ReadLine();
            while(line != null && counter++ <= spec.LastLine && i<count)
            {
                line = reader.ReadLine();
                if(counter >= spec.FirstLine)
                    seek(lines,i++) = Line(counter,line);
            }

            var target = ExtractPath(spec.DocId, spec.Unit);
            Emit(range, target);
            dst.Deposit(range);
        }

        TextLine Line(uint number, string content)
        {


            return TextLines.line(number,content);
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

        RecordSet<SplitSpec> GetSpecs()
        {
            lock(SpecsLocker)
            {
                if(Specs.IsNonEmpty)
                    return Specs;
                else
                {
                    var pipe = SplitSpecPipe.Service;
                    var outcome = pipe.Load(SpecPath, out Specs);
                    if(outcome.Fail)
                        Error(outcome.Message);
                    return Specs;
                }
            }
        }

        FS.FilePath RefDocPath(string id)
            => Workspace.RefDoc(id, FS.Txt);

        FS.FilePath ExtractPath(string id, string unit)
            => Workspace.DocExtract(id, unit, FS.Txt);

        FS.FilePath SpecPath
            => Workspace.DocRoot() + FS.file("splits", FS.Csv);
    }

    partial class XTend
    {
        public static DocSplitter Splitter(this IServiceContext context)
            => DocSplitter.create(context);
    }
}