//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmDocParts;
    using static TextRules;
    using static memory;

    public sealed class AsmDoc : Document<AsmDoc,Index<AsmDocLine>,FS.FilePath>
    {
        public static AsmDoc parse(FS.FilePath src)
            => parse(src.ReadText());

        public static AsmDoc parse(string src)
        {
            var lines = Parse.lines(src);
            var count = lines.Count;
            var dst = alloc<AsmDocLine>(count);
            ref var target = ref first(dst);
            ref readonly var source = ref lines.First;
            for(var i=0u; i<count; i++)
                seek(target,i) = new AsmDocLine(i, skip(source, i).Content);
            return new AsmDoc(dst);
        }

        public AsmDoc()
            : base(FS.FilePath.Empty, Index<AsmDocLine>.Empty)
        {

        }

        public AsmDoc(Index<AsmDocLine> content)
            : base(FS.FilePath.Empty, content)
        {

        }

        public AsmDoc(FS.FilePath src, Index<AsmDocLine> content)
            : base(src, content)
        {

        }

        public override AsmDoc Load(FS.FilePath location)
        {
           var doc = parse(location.ReadText());
           return new AsmDoc(location, doc.Content);
        }

        public override string Format()
        {
            var dst = Buffers.text();
            root.iter(Content, line => dst.AppendLine(line.Content));
            return dst.Emit();
        }
    }
}