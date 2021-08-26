//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static WsAtoms;
    using static Root;

    using K = llvm.LlvmConfigKind;
    using ST = llvm.stringtables;
    using SQ = SymbolicQuery;

    public partial class LlvmEtl : AppService<LlvmEtl>
    {
        LlvmRecordSources _LlvmRecordSources;

        llvm.Records LlvmRecords;

        llvm.LlvmDatasets LlvmDatasets;

        Index<llvm.OpCodeSpec> _LlvmOpCodes;

        public LlvmEtl()
        {
            _LlvmOpCodes = new();
        }

        protected override void Initialized()
        {
            LlvmRecords = Wf.LlvmRecords();
            LlvmDatasets = Wf.LlvmDatasets();
            _LlvmRecordSources = new ();
        }

        public LineMap<AsmId> MapAsmDefLines()
        {
            const uint BufferLength = 256;
            var result = Outcome.Success;
            var sources = LlvmRecords.Sources();
            var records = sources.Instructions.View;
            var linecount = records.Length;
            var defs = LlvmRecords.Defs(LlvmDatasetKind.Instructions);
            var count = defs.Length;
            var buffer = span<TextLine>(BufferLength);
            var intervals = list<LineInterval<AsmId>>();
            for(var i=0;i<count; i++)
            {
                ref readonly var d0 = ref skip(defs,i);
                if(!Enums.parse(d0.Name, out AsmId id))
                    continue;

                var k=0;
                buffer.Clear();
                var index = d0.Offset.Value;
                for(var j=index; j<linecount && k<BufferLength; j++)
                {
                    ref readonly var line = ref skip(records,j);
                    ref readonly var content = ref line.Content;
                    if(SQ.index(content, Chars.RBrace) != 0)
                    {
                        seek(buffer,k++) = line;
                    }
                    else
                        break;
                }

                if(k>0)
                {
                    ref readonly var l0 = ref first(buffer);
                    ref readonly var l1 = ref skip(buffer,k-1);
                    var interval = LineMaps.interval(id,l0.LineNumber, l1.LineNumber);
                    intervals.Add(interval);
                }
            }

            var map = LineMaps.map(intervals.ToArray());
            var dst = RecordMap("x86.instructions");
            var emitting = EmittingFile(dst);
            using var writer = dst.AsciWriter();
            var _intervals = map.Intervals;
            for(var i=0; i<_intervals.Length; i++)
            {
                ref readonly var ix = ref skip(_intervals,i);
                writer.WriteLine(string.Format("{0:D5} {1}", (ushort)ix.Id, ix));
            }

            EmittedFile(emitting, _intervals.Length);
            return map;
        }

        public Outcome QueryConfig()
        {
            const string Pattern = "llvm-config --{0}";
            var result = Outcome.Success;
            var options = Symbols.index<K>().View;
            var count = options.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var option = ref skip(options,i);
                var script = string.Format(Pattern, option.Expr);
                result = Wf.OmniScript().Run(script, out var response);
                if(result.Fail)
                    return result;

                if(response.Length != 0)
                    ProcessLlvmConfig(option, first(response));
            }

            return result;

        }

        void ProcessLlvmConfig(Sym<K> sym, TextLine src)
        {
            var content = src.Content;
            var kind = sym.Kind;
            Write(EmptyString);
            Write(sym.Name, sym.Description, FlairKind.StatusData);
            Write(RP.PageBreak40, FlairKind.StatusData);
            switch(kind)
            {
                case K.Version:
                    Write(content);
                break;
                case K.IncludeDir:
                {
                    var dir = FS.dir(content);
                    Write(dir);
                }
                break;
                case K.LibDir:
                {
                    var dir = FS.dir(content);
                    Write(dir);
                }
                break;
                case K.TargetsBuilt:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
                }
                break;
                case K.SrcRoot:
                {
                    var dir = FS.dir(content);
                    Write(dir);
                }
                break;
                case K.ObjRoot:
                {
                    var dir = FS.dir(content);
                    Write(dir);
                }
                break;
                case K.BinDir:
                {
                    var dir = FS.dir(content);
                    Write(dir);
                }
                break;
                case K.HostTarget:
                {
                    Write(content);
                }
                break;
                case K.CFlags:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
                }
                break;
                case K.CxxFlags:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
                }
                break;
                case K.SystemLibs:
                {
                    var items = content.Split(Chars.Space).Select(FS.file);
                    iter(items, c => Write(c));
                }
                break;
                case K.LibNames:
                {
                    var items = content.Split(Chars.Space).Select(FS.file);
                    iter(items, c => Write(c));
                }
                break;
                case K.CppFlags:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
                }
                break;
                case K.LinkerFlags:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
                }
                break;
                case K.LinkStatic:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
                }
                break;
                case K.Components:
                {
                    var items = content.Split(Chars.Space);
                    iter(items, c => Write(c));
                }
                break;
                case K.Libs:
                {
                    var items = content.Split(Chars.Space).Select(FS.path);
                    iter(items,p =>  Write(p.ToUri()));
                }
                break;
                case K.LibFiles:
                {
                    var items = content.Split(Chars.Space).Select(FS.path);
                    iter(items,p =>  Write(p.ToUri()));
                }
                break;
            }
        }

        public ReadOnlySpan<llvm.OpCodeSpec> LlvmOpCodes()
        {
            if(_LlvmOpCodes.IsEmpty)
                _LlvmOpCodes = MC.opcodes();
            return _LlvmOpCodes.View;
        }

        public Outcome RunEtl()
        {
            var result = Outcome.Success;
            result = EmitTables();
            TableEmit(LlvmOpCodes(), OpCodeSpec.RenderWidths, Ws.Tables().LlvmTable<OpCodeSpec>());
            ImportLists(LlvmDatasetNames.TblgenLists, llvm);
            GenStringTables();
            MapAsmDefLines();
            return result;
        }

        public Outcome ValidateStringTables()
        {
            var result = Outcome.Success;
            var runtime = MemoryStrings.load(ST.AVX512.Offsets, ST.AVX512.Data);
            var offsets = runtime.Offsets;
            var count = runtime.EntryCount;
            var formatter = Tables.formatter<MemoryStrings>();
            Write(formatter.Format(runtime, RecordFormatKind.KeyValuePairs));
            var symbols = Symbols.index<ST.AVX512.Index>();
            Write(string.Format("Symbols:{0}", symbols.Length));
            for(var i=0; i<offsets.Length; i++)
            {
                var l = MemoryStrings.length(runtime, i);
                if(l == 0)
                    break;
                var k = (ST.AVX512.Index)i;
                var o = skip(offsets,i);
                var c = text.format(runtime[i]);
                Write(string.Format("{0}[{1}]='{2}'", typeof(ST.AVX512).Name, i, c));
            }
            return result;
        }

        public Outcome GenStringTables()
        {
            const string TargetId = "llvm.stringtables";

            var result = Outcome.Success;
            var lists = Ws.Sources().Dataset(LlvmDatasetNames.TblgenLists).AllFiles.View;
            var count = lists.Length;
            var delimiter = Chars.Comma;
            var csdst = Ws.Gen().Path(TargetId, FS.Cs);
            var rowdst = Ws.Gen().Path(TargetId, FS.Csv);
            var formatter = Tables.formatter<StringTableRow>(StringTableRow.RenderWidths);
            using var cswriter = csdst.Writer();
            using var rowwriter = rowdst.AsciWriter();
            rowwriter.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(lists,i);
                var name = path.FileName.WithoutExtension.Format();
                var lines = path.ReadLines().View;
                var table = StringTables.create(lines, name, delimiter);
                var spec = StringTables.specify("Z0." + TargetId, table);
                StringTables.gencode(spec, cswriter);
                for(var j=0u; j<table.EntryCount; j++)
                {
                    var content = table[j];
                    ref readonly var id = ref table.Identifier(j);
                    var row = StringTables.row(table, j);
                    rowwriter.WriteLine(formatter.Format(row));
                }

                Write(string.Format("{0}: Stringtable emitted", arrow(path.ToUri(),csdst.ToUri())));
            }

            return result;
        }

        public Outcome GenLists()
        {
            var result = Outcome.Success;
            var path = Ws.Tools().Script(Toolspace.llvm_tblgen, ToolScriptId.emit_llvm_lists);
            result = Wf.OmniScript().RunToolScript(path, CmdVars.Empty, false, out var flow);
            ImportLists(LlvmDatasetNames.TblgenLists, llvm);
            return result;
        }

         void Emit(TableGenRecord src, FS.FilePath dst)
         {
            using var writer = dst.AsciWriter();
            foreach(var line in src.Lines)
            {
                writer.WriteLine(line.Content);
                Write(line);
            }

            if(src.Fields.Count != 0)
                iter(src.Fields, f => Write(f));
         }

        FS.FolderPath LlvmTables()
            => Ws.Tables().Subdir(llvm);


        FS.FilePath RecordIndex(string id)
            => LlvmTables() + FS.file(string.Format("{0}.index", id), FS.Csv);

        FS.FilePath RecordMap(string id)
            => LlvmTables() + FS.file(id,FS.ext("map"));

        public Outcome EmitTables()
        {
            var result = Outcome.Success;
            var sources = LlvmRecords.Sources();
            EmitLines(sources.Instructions.View, LlvmDatasets.Lined(LlvmDatasetKind.Instructions), TextEncodingKind.Asci);
            EmitLines(sources.Intrinsics.View, LlvmDatasets.Lined(LlvmDatasetKind.Intrinsics), TextEncodingKind.Asci);

            TableEmit(LlvmRecords.Defs(LlvmDatasetKind.Instructions, Records.DefinesInstruction), DefRecord.RenderWidths, RecordIndex("x86.instructions"));
            TableEmit(LlvmRecords.Classes(LlvmDatasetKind.Instructions), ClassRecord.RenderWidths, RecordIndex("x86.classes"));

            TableEmit(LlvmRecords.Defs(LlvmDatasetKind.Intrinsics), DefRecord.RenderWidths, RecordIndex("llvm.intrinsics"));
            return result;
        }


        public ReadOnlySpan<ListItem> ImportLists(string dataset, string dstid)
        {
            var input = Ws.Sources().Datasets(dataset).Files(FS.List, true);
            var count = input.Length;
            var formatter = Tables.formatter<ListItem>(ListItem.RenderWidths);
            var result = list<ListItem>();
            for(var i=0; i<count; i++)
            {
                ref readonly var src = ref skip(input,i);
                var name = src.FileName.WithoutExtension.Format();
                var members = items(src.ReadText().SplitClean(Chars.Comma).Select(x => x.Trim()).Where(text.nonempty).ToReadOnlySpan()).View;
                var mCount = members.Length;
                var dst = Ws.Tables().Subdir(dstid) + FS.folder(lists) + src.FileName.ChangeExtension(FS.Csv);
                using var writer = dst.AsciWriter();
                writer.WriteLine(formatter.FormatHeader());
                for(var j=0; j<mCount; j++)
                {
                    ref readonly var member = ref skip(members,j);
                    var row = member.ToRecord(name);
                    result.Add(row);
                    writer.WriteLine(formatter.Format(row));
                }
                Write(FS.flow(src,dst));
            }
            return result.ViewDeposited();
        }
    }
}