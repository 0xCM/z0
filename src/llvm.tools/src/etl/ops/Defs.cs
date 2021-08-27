//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    using SQ = SymbolicQuery;

    partial class EtlWorkflow
    {
        public static bool DefinesInstruction(DefRecord src)
        {
            bit result = 1;
            result &= Enums.parse(src.Name, out AsmId dst);
            result &= (src.Ancestors.StartsWith("InstructionEncoding"));
            return result;
        }

        public ReadOnlySpan<DefRecord> Defs(LlvmDatasetKind kind)
            => Defs(kind, x => true);

        public ReadOnlySpan<DefRecord> Defs(LlvmDatasetKind kind, Func<DefRecord,bool> filter)
        {
            var source = Index<TextLine>.Empty;

            switch(kind)
            {
                case LlvmDatasetKind.Instructions:
                    source = Sources.Instructions;
                break;
                case LlvmDatasetKind.Intrinsics:
                    source = Sources.Intrinsics;
                break;
                case LlvmDatasetKind.ValueTypes:
                    source = Sources.ValueTypes;
                break;
            }
            return Defs(source,kind, filter);
        }

        public ReadOnlySpan<ClassRecord> Classes(LlvmDatasetKind kind, Func<ClassRecord,bool> filter)
        {
            var source = Index<TextLine>.Empty;

            switch(kind)
            {
                case LlvmDatasetKind.Instructions:
                    source = Sources.Instructions;
                break;
                case LlvmDatasetKind.Intrinsics:
                    source = Sources.Intrinsics;
                break;
                case LlvmDatasetKind.ValueTypes:
                    source = Sources.ValueTypes;
                break;
            }
            return Classes(source,kind, filter);
        }

        public Outcome<FS.FilePath> Load(LlvmDatasetKind kind, ref LlvmRecordSources dst)
        {
            return load(Ws.Sources(), kind,ref dst);
        }

        Outcome<FS.FilePath> load(IWorkspace sources, LlvmDatasetKind kind, ref LlvmRecordSources dst)
        {
            var path = LlvmPaths.DataSourcePath(kind);
            switch(kind)
            {
                case LlvmDatasetKind.Intrinsics:
                    {
                        using var reader = path.Utf8LineReader();
                        dst.Intrinsics = reader.ReadAll().ToArray();
                    }
                break;
                case LlvmDatasetKind.Instructions:
                    {
                        using var reader = path.Utf8LineReader();
                        dst.Instructions = reader.ReadAll().ToArray();
                    }
                break;
                case LlvmDatasetKind.ValueTypes:
                    {
                        using var reader = path.Utf8LineReader();
                        dst.ValueTypes = reader.ReadAll().ToArray();
                    }
                break;
            }

            return path.IsNonEmpty ? (true,path) : false;
        }

        ReadOnlySpan<DefRecord> Defs(ReadOnlySpan<TextLine> src, LlvmDatasetKind kind, Func<DefRecord,bool> filter)
        {
            const string Marker = "def ";
            var fields = list<RecordField>();
            var lines = list<TextLine>();
            var dst = list<DefRecord>();
            var name = EmptyString;
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var line = ref skip(src,i);
                var content = line.Content;
                var j = text.index(content, Marker);
                var isDefEnd = text.begins(content, Chars.RBrace);
                if(j >= 0)
                {
                    var k = text.index(content, Chars.LBrace);
                    if(k>=0)
                    {
                        var record = new DefRecord();
                        record.Dataset = kind;
                        record.Offset = line.LineNumber;
                        record.Name = text.trim(text.between(content, j + Marker.Length - 1, k));
                        var m = SQ.index(content, Chars.FSlash, Chars.FSlash);
                        if(m >= 0)
                            record.Ancestors = text.trim(text.right(content, m + 1));
                        if(filter(record))
                            dst.Add(record);
                    }
                }
            }

            var results = dst.ToArray();
            return results;
        }


        LlvmRecordSources LoadRecordSources()
        {
            if(Sources.IsEmtpty)
            {
                var result = Load(LlvmDatasetKind.Instructions, ref Sources);
                result.OnSuccess(path => Write(path.ToUri().Format(), Sources.Instructions.Count));

                result = Load(LlvmDatasetKind.Intrinsics, ref Sources);
                result.OnSuccess(path => Write(path.ToUri().Format(), Sources.Intrinsics.Count));

                result = Load(LlvmDatasetKind.ValueTypes, ref Sources);
                result.OnSuccess(path => Write(path.ToUri().Format(), Sources.ValueTypes.Count));

                Write(string.Format("Loaded {0} lines", Sources.TotalLineCount()));
            }
            return Sources;
        }
    }
}