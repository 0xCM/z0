//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.InteropServices;

    using static core;
    using static Root;

    using SQ = SymbolicQuery;

    [ApiHost("llvm.records")]
    public partial class Records : WsService<Records>
    {
        LlvmRecordSources _Sources;

        public Records()
        {
            _Sources = new();
        }

        public ReadOnlySpan<DefRecord> Defs(LlvmDatasetKind kind)
            => Defs(kind, x => true);

        public ReadOnlySpan<ClassRecord> Classes(LlvmDatasetKind kind)
            => Classes(kind, x => true);

        public ReadOnlySpan<DefRecord> Defs(LlvmDatasetKind kind, Func<DefRecord,bool> filter)
        {
            var sources = Sources();
            var source = Index<TextLine>.Empty;

            switch(kind)
            {
                case LlvmDatasetKind.Instructions:
                    source = sources.Instructions;
                break;
                case LlvmDatasetKind.Intrinsics:
                    source = sources.Intrinsics;
                break;
                case LlvmDatasetKind.ValueTypes:
                    source = sources.ValueTypes;
                break;
            }
            return Defs(source,kind, filter);
        }

        public ReadOnlySpan<ClassRecord> Classes(LlvmDatasetKind kind, Func<ClassRecord,bool> filter)
        {
            var sources = Sources();
            var source = Index<TextLine>.Empty;

            switch(kind)
            {
                case LlvmDatasetKind.Instructions:
                    source = sources.Instructions;
                break;
                case LlvmDatasetKind.Intrinsics:
                    source = sources.Intrinsics;
                break;
                case LlvmDatasetKind.ValueTypes:
                    source = sources.ValueTypes;
                break;
            }
            return Classes(source,kind, filter);
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

        ReadOnlySpan<ClassRecord> Classes(ReadOnlySpan<TextLine> src, LlvmDatasetKind kind, Func<ClassRecord,bool> filter)
        {
            const string Marker = "class ";
            var fields = list<RecordField>();
            var lines = list<TextLine>();
            var dst = list<ClassRecord>();
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
                        var record = new ClassRecord();
                        record.Dataset = kind;
                        record.Offset = line.LineNumber;
                        var lt = text.index(content,Chars.Lt);
                        if(lt >=0)
                            record.Name = text.trim(text.between(content, j + Marker.Length - 1, lt));
                        else
                        {
                            record.Name = text.trim(text.between(content, j + Marker.Length - 1, k));
                        }
                        //record.Name = text.trim(text.between(content, j + Marker.Length - 1, k));
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

        public LlvmRecordSources Sources()
        {
            if(_Sources.IsEmtpty)
            {
                var svc = Wf.LlvmDatasets();

                var result = svc.Load(LlvmDatasetKind.Instructions, ref _Sources);
                result.OnSuccess(path => Write(path.ToUri().Format(), _Sources.Instructions.Count));

                result = svc.Load(LlvmDatasetKind.Intrinsics, ref _Sources);
                result.OnSuccess(path => Write(path.ToUri().Format(), _Sources.Intrinsics.Count));

                result = svc.Load(LlvmDatasetKind.ValueTypes, ref _Sources);
                result.OnSuccess(path => Write(path.ToUri().Format(), _Sources.ValueTypes.Count));

                Write(string.Format("Loaded {0} lines", _Sources.TotalLineCount()));
            }
            return _Sources;
        }
    }
}