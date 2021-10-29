//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Collections.Generic;

    using static Root;
    using static Names;
    using static core;

    public sealed class LlvmDb : AppService<LlvmDb>
    {
        new LlvmPaths Paths;

        Index<TextLine> X86Records;

        LineMap<Identifier> ClassMap;

        LineMap<Identifier> DefMap;

        IdentityMap<uint> DefLookup;

        public LlvmDb()
        {
            X86Records = Index<TextLine>.Empty;
            ClassMap = LineMap<Identifier>.Empty;
            DefMap = LineMap<Identifier>.Empty;
            DefLookup = new();

        }

        protected override void Initialized()
        {
            Paths = Wf.LlvmPaths();
            LoadRecords();
        }

        public void Classes()
        {
            var count = ClassMap.IntervalCount;
            for(var i=0; i<count; i++)
            {
                ref readonly var entry = ref ClassMap[i];
                Write(entry.Format());
            }
        }

        public void Defs()
        {
            var count = DefMap.IntervalCount;
            for(var i=0; i<count; i++)
            {
                ref readonly var entry = ref DefMap[i];
                Write(entry.Format());
            }
        }

        public void Def(Identifier name)
        {
            if(DefLookup.Mapped(name, out var i))
            {
                ref readonly var entry = ref DefMap[i];
                var j0 = entry.MinLine - 1;
                var j1 = entry.MaxLine;
                for(var k=j0; k<j1; k++)
                {
                    ref readonly var line = ref X86Records[k];
                    Write(line.Format());
                }
            }
            else
            {
                Write(string.Format("{0} not found", name));
            }
        }

        void LoadRecords()
        {
            using var r0 = Paths.RecordImport(Datasets.X86Lined, FS.Txt).Utf8LineReader();
            X86Records = r0.ReadAll().ToArray();
            ClassMap = LoadLineMap(Paths.ImportMap(Datasets.X86Classes));
            DefMap = LoadLineMap(Paths.ImportMap(Datasets.X86Defs));
            iteri(DefMap.Intervals, (i,entry) => DefLookup.Map(entry.Id, (uint)i));

        }

        LineMap<Identifier> LoadLineMap(FS.FilePath src)
        {
            using var reader = src.Utf8LineReader();
            var lines = reader.ReadAll();
            var interval = LineInterval<Identifier>.Empty;
            var count = lines.Length;
            var intervals = alloc<LineInterval<Identifier>>(count);
            var result = Outcome.Success;
            for(var i=0u; i<count; i++)
            {
                ref var dst = ref seek(intervals, i);
                result = DataParser.parse(skip(lines,i).Content, out seek(intervals,i));
                if(result.Fail)
                {
                    Error(result.Message);
                    break;
                }
            }

            if(result)
                return new LineMap<Identifier>(intervals);
            else
                return new LineMap<Identifier>(sys.empty<LineInterval<Identifier>>());
        }
    }
}