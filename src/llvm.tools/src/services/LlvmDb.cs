//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using Z0.Strings;

    using records;

    using static Root;
    using static LlvmNames;
    using static core;

    public sealed class LlvmDb : AppService<LlvmDb>
    {
        new LlvmPaths Paths;

        Index<TextLine> X86Records;

        LineMap<Identifier> ClassMap;

        LineMap<Identifier> DefMap;

        IdentityMap<uint> DefLookup;

        Index<TableGenField> DefFields;

        IdentityMap<Interval<uint>> FieldMap;

        BufferedLabels ClassNameBuffer;

        BufferedLabels DefNameBuffer;

        public LlvmDb()
        {
            X86Records = Index<TextLine>.Empty;
            ClassMap = LineMap<Identifier>.Empty;
            DefMap = LineMap<Identifier>.Empty;
            DefLookup = new();
            FieldMap = new();
        }

        protected override void Initialized()
        {
            Paths = Wf.LlvmPaths();
            LoadRecords();
        }

        protected override void Disposing()
        {
            ClassNameBuffer.Dispose();
            DefNameBuffer.Dispose();
        }
        public ReadOnlySpan<TableGenField> Fields(uint offset, uint length)
            => slice(DefFields.View, offset,length);

        public ReadOnlySpan<TableGenField> Fields(Identifier id)
        {
            if(FieldMap.Mapped(id, out var interval))
            {
                var i = interval.Left;
                var j = interval.Right;
                return slice(DefFields.View,i, j - i);
            }
            else
                return default;
        }



        public ReadOnlySpan<Label> ClassNames()
            => ClassNameBuffer.Labels;

        public ReadOnlySpan<Label> DefNames()
            => DefNameBuffer.Labels;

        public void Fields(Action<IFieldProvider> receiver)
        {
            var defcount = DefMap.IntervalCount;
            for(var i=0; i<defcount; i++)
                receiver(new FieldProvider(DefMap[i].Id,this));
        }

        public void Classes(StreamWriter dst)
        {
            var count = ClassMap.IntervalCount;
            for(var i=0; i<count; i++)
                dst.WriteLine(ClassMap[i].Format());
        }



        public void Defs(StreamWriter dst)
        {
            var count = DefMap.IntervalCount;
            for(var i=0; i<count; i++)
                dst.WriteLine(DefMap[i].Format());
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

        public ReadOnlySpan<DefRelations> LoadDefRelations()
        {
            var src = Paths.Table<DefRelations>();
            var dst = list<DefRelations>();
            var rows = src.ReadLines();
            var count = rows.Length;
            var result = Outcome.Success;
            for(var i=1; i<count; i++)
            {
                var record = new DefRelations();
                ref readonly var row = ref rows[i];
                var cells = @readonly(row.Split(Chars.Pipe).Select(x => x.Trim()));
                if(cells.Length != DefRelations.FieldCount)
                {
                    Error(Tables.FieldCountMismatch.Format(DefRelations.FieldCount, cells.Length));
                    Write(row);
                    break;
                }
                var j=0;
                result = DataParser.parse(skip(cells,j++), out record.SourceLine);
                if(result.Fail)
                {
                    Error(result.Message);
                    break;
                }
                result = DataParser.parse(skip(cells,j++), out record.Name);
                if(result.Fail)
                {
                    Error(result.Message);
                    break;
                }
                record.Ancestors = Lineage.parse(skip(cells, j++));
                dst.Add(record);
            }
            return dst.ViewDeposited();
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

        void LoadDefFields()
        {
            var result = Outcome.Success;
            var src = Paths.Table(Datasets.X86DefFields);
            var count = FS.linecount(src);
            DefFields = alloc<TableGenField>(count.Lines);
            var counter = 0u;
            using var reader = src.Utf8LineReader();
            var id = Identifier.Empty;
            var i = 0u;
            var j = 0u;
            while(reader.Next(out var line))
            {
                result = parse(line, out var fields);
                if(result.Fail)
                {
                    Error(result.Message);

                    break;
                }

                DefFields[counter++] = fields;
            }
        }

        void LoadRecords()
        {
            var running = Running("Loading data");
            using var r0 = Paths.RecordImport(Datasets.X86Lined, FS.Txt).Utf8LineReader();
            X86Records = r0.ReadAll().ToArray();
            ClassMap = LoadLineMap(Paths.ImportMap(Datasets.X86Classes));
            DefMap = LoadLineMap(Paths.ImportMap(Datasets.X86Defs));
            ClassNameBuffer = strings.labels(ClassMap.Intervals.Select(x => x.Id.Content));
            DefNameBuffer = strings.labels(DefMap.Intervals.Select(x => x.Id.Content));
            iteri(DefMap.Intervals, (i,entry) => DefLookup.Map(entry.Id, (uint)i));
            LoadDefFields();
            Ran(running, string.Format("Loaded {0} fields from {1} records", DefFields.Count, X86Records.Count));
        }

        static Outcome parse(in TextLine src, out TableGenField dst)
        {
            var result = Outcome.Success;
            dst = default;
            var parts = src.Split(Chars.Pipe);
            var count = parts.Length;
            if(count < 4)
                return (false, Tables.FieldCountMismatch.Format(4,count));

            dst.Id = skip(parts,0);
            dst.FieldContent.DataType = skip(parts,1);
            dst.FieldContent.Name = skip(parts,2);
            dst.FieldContent.Value = skip(parts,3);
            return result;
        }
    }
}