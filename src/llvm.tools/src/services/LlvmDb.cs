//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

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

        IdentityMap<uint> ClassLookup;

        Index<RecordField> _DefFields;

        Index<RecordField> _ClassFields;

        IdentityMap<Interval<uint>> FieldDefMap;

        BufferedLabels ClassNameBuffer;

        BufferedLabels DefNameBuffer;

        public LlvmDb()
        {
            X86Records = Index<TextLine>.Empty;
            ClassMap = LineMap<Identifier>.Empty;
            DefMap = LineMap<Identifier>.Empty;
            DefLookup = new();
            FieldDefMap = new();
            ClassLookup = new();
        }

        protected override void Initialized()
        {
            Paths = Wf.LlvmPaths();
            LoadData();
        }

        protected override void Disposing()
        {
            ClassNameBuffer.Dispose();
            DefNameBuffer.Dispose();
        }

        public ReadOnlySpan<RecordField> Fields(uint offset, uint length)
            => slice(_DefFields.View, offset,length);

        public ReadOnlySpan<RecordField> Fields(Identifier id)
        {
            if(FieldDefMap.Mapped(id, out var interval))
            {
                var i = interval.Left;
                var j = interval.Right;
                return slice(_DefFields.View, i, j - i);
            }
            else
            {
                Warn(string.Format("{0} not found", id));
                return default;
            }
        }

        public ItemList List(string type)
        {
            var path = Paths.ListImportPath(type);
            var result = Tables.list(path, out var items);
            if(result.Fail)
            {
                Error(result.Message);
                return ItemList.Empty;
            }
            return items;
        }

        public ReadOnlySpan<Label> ClassNames()
            => ClassNameBuffer.Labels;

        public ReadOnlySpan<Label> DefNames()
            => DefNameBuffer.Labels;

        public ReadOnlySpan<RecordField> ClassFields()
            => _ClassFields.View;

        public ReadOnlySpan<RecordField> DefFields()
            => _DefFields.View;

        public void Fields(Action<IFieldProvider> receiver)
        {
            var defcount = DefMap.IntervalCount;
            for(var i=0; i<defcount; i++)
                receiver(new FieldProvider(DefMap[i].Id, this));
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

        public ReadOnlySpan<TextLine> DefLines(Identifier name)
        {
            var lines = list<TextLine>();
            if(DefLookup.Mapped(name, out var i))
            {
                ref readonly var entry = ref DefMap[i];
                var j0 = entry.MinLine - 1;
                var j1 = entry.MaxLine;
                for(var k=j0; k<j1; k++)
                {
                    lines.Add(X86Records[k]);
                }
            }
            else
                Write(AppMsg.NotFound.Format(name));
            return lines.ViewDeposited();
        }

        public ReadOnlySpan<TextLine> ClassLines(Identifier name)
        {
            var lines = list<TextLine>();
            if(ClassLookup.Mapped(name, out var i))
            {
                ref readonly var entry = ref DefMap[i];
                var j0 = entry.MinLine - 1;
                var j1 = entry.MaxLine;
                for(var k=j0; k<j1; k++)
                    lines.Add(X86Records[k]);
            }
            else
                Write(AppMsg.NotFound.Format(name));
            return lines.ViewDeposited();
        }

        public ReadOnlySpan<ClassRelations> LoadClassRelations()
        {
            var src = Paths.Table<ClassRelations>();
            var dst = list<ClassRelations>();
            var rows = src.ReadLines();
            var count = rows.Length;
            var result = Outcome.Success;
            for(var i=1; i<count; i++)
            {
                var record = new ClassRelations();
                ref readonly var row = ref rows[i];
                var cells = @readonly(row.Split(Chars.Pipe).Select(x => x.Trim()));
                if(cells.Length != ClassRelations.FieldCount)
                {
                    Error(Tables.FieldCountMismatch.Format(ClassRelations.FieldCount, cells.Length));
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
                record.Parameters = skip(cells,j++);
                dst.Add(record);
            }
            return dst.ViewDeposited();
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
                result = DataParser.parse(skip(cells, j++), out record.SourceLine);
                if(result.Fail)
                {
                    Error(result.Message);
                    break;
                }
                result = DataParser.parse(skip(cells, j++), out record.Name);
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

        // void LoadDefFields()
        // {
        //     var src = Paths.Table(Datasets.X86DefFields);
        //     var count = FS.linecount(src);
        //     DefFields = alloc<RecordField>(count.Lines);
        //     var counter = 0u;
        //     using var reader = src.Utf8LineReader();
        //     var id = Identifier.Empty;
        //     var i = 0u;
        //     var j = 0u;
        //     while(reader.Next(out var line))
        //     {
        //         var result = parse(line, out var field);
        //         if(result.Fail)
        //         {
        //             Error(result.Message);
        //             break;
        //         }

        //         DefFields[counter++] = field;
        //     }
        // }

        void LoadFields(string dataset, out Index<RecordField> dst)
        {
            var src = Paths.Table(dataset);
            var count = FS.linecount(src);
            dst = alloc<RecordField>(count.Lines);
            var counter = 0u;
            using var reader = src.Utf8LineReader();
            var id = Identifier.Empty;
            var i = 0u;
            var j = 0u;
            while(reader.Next(out var line))
            {
                var result = parse(line, out var field);
                if(result.Fail)
                {
                    Error(result.Message);
                    break;
                }

                dst[counter++] = field;
            }
        }

        void LoadDefs()
        {
            DefMap = LoadLineMap(Paths.ImportMap(Datasets.X86Defs));
            DefNameBuffer = strings.labels(DefMap.Intervals.Select(x => x.Id.Content));
            iteri(DefMap.Intervals, (i,entry) => DefLookup.Map(entry.Id, (uint)i));
            iteri(DefMap.Intervals, (i,entry) => FieldDefMap.Map(entry.Id, (entry.MinLine,entry.MaxLine)));
            LoadFields(Datasets.X86DefFields, out _DefFields);
        }

        void LoadClasses()
        {
            ClassMap = LoadLineMap(Paths.ImportMap(Datasets.X86Classes));
            ClassNameBuffer = strings.labels(ClassMap.Intervals.Select(x => x.Id.Content));
            iteri(ClassMap.Intervals, (i,entry) => ClassLookup.Map(entry.Id, (uint)i));
            LoadFields(Datasets.X86ClassFields, out _ClassFields);
        }

        void LoadRecordLines()
        {
            using var reader = Paths.RecordImport(Datasets.X86Lined, FS.Txt).Utf8LineReader();
            X86Records = reader.ReadAll().ToArray();
        }

        void LoadData()
        {
            var flow = Running("Loading data");
            LoadRecordLines();
            LoadClasses();
            LoadDefs();
            Ran(flow, string.Format("Loaded {0} fields from {1} records", _DefFields.Count, X86Records.Count));
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

        static Outcome parse(in TextLine src, out RecordField dst)
        {
            var result = Outcome.Success;
            dst = default;
            var parts = src.Split(Z0.Chars.Pipe);
            var count = parts.Length;
            if(count < 4)
                return (false, Tables.FieldCountMismatch.Format(4, count));

            dst.RecordName = skip(parts,0);
            dst.DataType = skip(parts,1);
            dst.Name = skip(parts,2);
            dst.Value = skip(parts,3);
            return result;
        }
    }
}