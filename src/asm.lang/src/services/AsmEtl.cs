//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using static Root;
    using static core;
    using static Msg;

    [ApiHost]
    public class AsmEtl : AppService<AsmEtl>
    {
        public Index<SdmOpCodeDetail> ImportSdmOpCodes()
        {
            var result = Outcome.Success;
            var src = Ws.Sources().Datasets(AsmTableScopes.SdmInstructions).Files(FS.Csv).ToReadOnlySpan();
            var svc = Wf.IntelSdm();
            return Wf.IntelSdm().ImportOpCodeDetails(src);
        }

        public ReadOnlySpan<Table> ReadSdmTables()
        {
            var src = Ws.Sources().Datasets(AsmTableScopes.SdmInstructions).Files(FS.Csv).ToReadOnlySpan();
            var svc = Wf.IntelSdm();
            return svc.ReadCsvTables(src);
        }

        /// <summary>
        /// Distills <see cref='AsmForm'/> values from a <see cref='SdmOpCodeDetail'/> sequence
        /// </summary>
        /// <param name="src">The data source</param>
        [Op]
        static Index<AsmForm> forms(ReadOnlySpan<SdmOpCodeDetail> src)
        {
            var count = src.Length;
            var buffer = alloc<AsmForm>(count);
            ref var dst = ref first(buffer);

            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(src,i);
                ref var opcode = ref SdmModels.opcode(record, out _);
                ref var form = ref seek(dst,i);
                form = asm.form(
                    asm.sig(opcode.Mnemonic.Format(), SdmModels.operands(opcode)),
                    asm.opcode((ushort)opcode.OpCodeId, opcode.Expr)
                    );
            }
            return buffer;
        }

        public ReadOnlySpan<AsmForm> EmitAsmForms(ReadOnlySpan<SdmOpCodeDetail> opcodes, FS.FilePath dst)
        {
            const string Pattern = "{0,-80} | {1}:{2} | {3}:{4}";
            var ws = Ws.Tables();
            using var writer = dst.UnicodeWriter();
            var _forms = forms(opcodes).View;
            var count = _forms.Length;
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(_forms,i));

            return _forms;
        }

        public Outcome LoadImportedOpCodes(FS.FilePath src, out SdmOpCodeDetail[] dst)
        {
            var result = Outcome.Success;
            dst = sys.empty<SdmOpCodeDetail>();
            var lines = src.ReadLines(TextEncodingKind.Unicode).View;
            result = TextGrids.load(lines, out var grid);
            if(result.Fail)
                return result;
            var count = grid.RowCount;
            dst = alloc<SdmOpCodeDetail>(count);
            result = AsmParser.parse(grid, dst);
            if(result.Fail)
                return result;

            return result;
        }

        public Outcome EmitOpCodeStrings(ReadOnlySpan<SdmOpCodeDetail> src)
        {
            var result = Outcome.Success;
            var count = src.Length;
            var items = alloc<ListItem<string>>(count);
            for(var i=0u; i<count; i++)
                seek(items,i) = (i,skip(src,i).OpCode);

            var dst = Wf.EnvPaths.Codebase(PartId.AsmData) + FS.folder("src/sources/gen");
            var spec = StringTables.specify("Z0.Asm", "OpCodeStrings", items);
            return Wf.Generators().Generate(spec,dst);
        }

        public Index<HostAsmRecord> LoadHostAsmRows(FS.FilePath src)
        {
            var result = TextGrids.load(src, out var doc);
            if(!result)
            {
                Error(result.Message);
                return default;
            }
            else
            {
                var dst = alloc<HostAsmRecord>(doc.RowCount);
                var count = AsmParser.parse(doc, dst);
                if(count)
                    return dst;

                Error(count.Message);
                return default;
            }
        }

        public static void traverse(FS.FilePath src, Receiver<ProcessAsmRecord> dst)
        {
            var counter = 1u;
            using var reader = src.Utf8Reader();
            var header = reader.ReadLine();
            var line = reader.ReadLine();
            var result = Outcome.Success;
            while(line != null && result.Ok)
            {
                result = AsmParser.parse(counter++, line, out var row);
                if(result.Ok)
                    dst(row);
                line = reader.ReadLine();
            }
        }

        [Op]
        public static HexVector32 offsets(ReadOnlySpan<ProcessAsmRecord> src)
        {
            var count = src.Length;
            var buffer = alloc<Hex32>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i).GlobalOffset;
            return buffer;
        }

        public static uint load(FS.FilePath src, List<AsmLine> dst)
        {
            var counter = 0u;
            using var reader = src.AsciLineReader();
            while(reader.Next(out var line))
            {
                if(AsmParser.parse(line, out AsmBlockLabel label, out AsmExpr expr))
                {
                    if(AsmParser.parse(label, out AsmOffsetLabel offset))
                    {
                        dst.Add(asm.line(offset, expr));
                        counter++;
                    }
                    else
                    {
                        if(expr.IsNonEmpty)
                        {
                            dst.Add(asm.line(label, expr));
                            counter++;
                        }
                        else
                        {
                            dst.Add(asm.line(label));
                            counter++;
                        }
                    }
                }
            }
            return counter;
        }

        public ReadOnlySpan<AsmThumbprint> LoadThumbprints(FS.FilePath src)
        {
            var dst = list<AsmThumbprint>();
            using var reader = src.Utf8Reader();
            while(!reader.EndOfStream)
            {
                var data = reader.ReadLine();
                var statement = asm.expr(data.LeftOfFirst(Chars.Semicolon));
                var tpResult = AsmParser.thumbprint(data, out var thumbprint);
                if(tpResult)
                    dst.Add(thumbprint);
                else
                    Error(tpResult.Message);
            }
            return dst.ToArray();
        }

        public ReadOnlySpan<TextLine> EmitThumbprints(SortedSpan<AsmEncodingInfo> src, FS.FilePath dst)
        {
            var count = src.Length;
            var emitting = EmittingFile(dst);
            var lines = span<TextLine>(count);
            using var writer = dst.Writer();
            for(var i=0u; i<count; i++)
            {
                var content = AsmRender.thumbprint(SortedSpans.skip(src,i));
                writer.WriteLine(content);
                seek(lines,i) = (i,content);
            }
            EmittedFile(emitting, count);
            return lines;
        }

        public void EmitThumbprints(SortedSpan<ProcessAsmRecord> src, FS.FilePath dst)
            => EmitThumbprints(DistinctEncodings(src), dst);

        public void EmitThumbprints(ReadOnlySpan<AsmThumbprint> src, FS.FilePath dst)
        {
            var flow = EmittingFile(dst);
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(AsmRender.format(skip(src,i)));
            EmittedFile(flow, count);
        }

        public ReadOnlySpan<TextLine> EmitThumbprints(SortedSpan<AsmThumbprint> src, FS.FilePath dst)
        {
            var count = src.Length;
            var emitting = EmittingFile(dst);
            var lines = span<TextLine>(count);
            using var writer = dst.Writer();
            for(var i=0u; i<count; i++)
            {
                var content = AsmRender.thumbprint(SortedSpans.skip(src,i), true);
                writer.WriteLine(content);
                seek(lines,i) = (i,content);
            }
            EmittedFile(emitting, count);
            return lines;
        }

        public SortedSpan<AsmThumbprint> DistinctThumbprints(ReadOnlySpan<HostAsmRecord> src)
        {
            var distinct = hashset<AsmThumbprint>();
            iter(src, s => distinct.Add(asm.thumbprint(s)));
            return distinct.Array().ToSortedSpan();
        }

        public SortedSpan<AsmThumbprint> EmitThumbprints(ReadOnlySpan<HostAsmRecord> src, FS.FilePath dst)
        {
            var distinct = DistinctThumbprints(src);
            EmitThumbprints(distinct, dst);
            return distinct;
        }

        [MethodImpl(Inline), Op]
        public static BinaryCode code(in CodeBlock src, uint offset, byte size)
            => slice(src.View, offset, size).ToArray();

        public static SortedSpan<AsmEncodingInfo> DistinctEncodings(ReadOnlySpan<ProcessAsmRecord> src)
        {
            var collected = hashset<AsmEncodingInfo>();
            var count = src.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var statement = ref skip(src,i);
                if(collected.Add(AsmEncoding.describe(statement)))
                    counter++;
            }
            return collected.Array().ToSortedSpan();
        }

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSet<T> rowset<T>(T key, AsmDetailRow[] src)
            => new AsmRowSet<T>(key,src);


        public Index<HostAsmRecord> LoadHostAsmRows(FS.FolderPath src, bool pll = true, bool sort = true)
        {
            var files = src.Files(FS.Csv, true);
            var flow = Running(LoadingStatements.Format(src));
            var counter = 0u;
            var dst = bag<HostAsmRecord>();
            if(pll)
            {
                Status(LoadingDocs.Format(files.Length));
                var docs = TextGrids.load(files);

                Status(ParsingDocs.Format(docs.Length));
                var results = parse(docs, dst);
                foreach(var result in results)
                    result.OnSuccess(count => counter+=count).OnFailure(msg => Error(msg));
            }
            else
            {
                foreach(var file in files)
                {
                    var result = TextGrids.load(file, out var grid);
                    if(result.Fail)
                    {
                        Error(result.Message);
                        continue;
                    }

                    var parsed = AsmParser.parse(grid, dst);
                    if(parsed.Fail)
                        Error(FileParseError.Format(file, result.Message));
                    else
                        counter += parsed.Data;
                }
            }

            Ran(flow, ParsedStatements.Format(counter));

            var records = dst.ToArray();
            if(sort)
                Array.Sort(records);
            return records;
        }

        public static uint ProcessAsmCount(FS.FilePath src)
        {
            var counter = 0u;
            using var reader = src.AsciReader();
            var header = reader.ReadLine();
            var line = reader.ReadLine();
            while(line != null)
            {
                counter++;
                line = reader.ReadLine();
            }

            return counter;
        }

        public static Outcome<uint> LoadProcessAsm(FS.FilePath src, Span<ProcessAsmRecord> dst)
        {
            var counter = 1u;
            var i = 0u;
            var max = dst.Length;
            using var reader = src.AsciReader();
            var header = reader.ReadLine();
            var line = reader.ReadLine();
            var result = Outcome.Success;
            while(line != null && result.Ok)
            {
                result = AsmParser.parse(counter++, line, out seek(dst,i));
                if(result.Fail)
                    return result;
                else
                    i++;

                line = reader.ReadLine();
            }
            return i;
        }

        static Index<Outcome<uint>> parse(ReadOnlySpan<TextGrid> src, ConcurrentBag<HostAsmRecord> dst)
        {
            var results = bag<Outcome<uint>>();
            iter(src, doc => {
                results.Add(AsmParser.parse(doc, dst));
            }, true);
            return results.ToArray();
        }
    }
}