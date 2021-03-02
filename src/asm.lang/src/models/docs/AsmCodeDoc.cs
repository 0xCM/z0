//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static TextRules;
    using static memory;

    public sealed class AsmCodeDoc : Document<AsmCodeDoc,Index<AsmStatementLine>,FS.FilePath>
    {
        public static AsmCodeDoc parse(FS.FilePath src)
            => parse(src.ReadText());

        public static AsmCodeDoc parse(string src)
        {
            var lines = Parse.lines(src);
            var count = lines.Count;
            var dst = alloc<AsmStatementLine>(count);
            ref var target = ref first(dst);
            ref readonly var source = ref lines.First;
            for(var i=0u; i<count; i++)
            {

                //seek(target,i) = new AsmCodeLine(i, skip(source, i).Content);
            }
            return new AsmCodeDoc(dst);
        }

        public AsmCodeDoc()
            : base(FS.FilePath.Empty, Index<AsmStatementLine>.Empty)
        {

        }

        public AsmCodeDoc(Index<AsmStatementLine> content)
            : base(FS.FilePath.Empty, content)
        {

        }

        public AsmCodeDoc(FS.FilePath src, Index<AsmStatementLine> content)
            : base(src, content)
        {

        }

        public override AsmCodeDoc Load(FS.FilePath location)
        {
           var doc = parse(location.ReadText());
           return new AsmCodeDoc(location, doc.Content);
        }

        public override string Format()
        {
            var dst = Buffers.text();
            root.iter(Content, line => dst.AppendLine(line.Format()));
            return dst.Emit();
        }

        public static AsmCodeDoc Empty => new AsmCodeDoc();
    }
}