//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    using static Root;
    using static core;

    public sealed partial class StanfordAsmCatalog : AppService<StanfordAsmCatalog>
    {
        readonly TextDocFormat SourceFormat;

        readonly Index<StokeAsmImportRow> RowBuffer;

        const uint MaxRowCount = 2500;

        const char AsmCatDelimiter = Chars.Tab;

        public StanfordAsmCatalog()
        {
            SourceFormat = TextDocFormat.Structured(AsmCatDelimiter, false);
            RowBuffer = alloc<StokeAsmImportRow>(MaxRowCount);
        }

        public uint ImportRowCount {get; private set;}

        public Index<StokeAsmExportRow> ExportImport()
        {
            var src = Wf.Db().Table<StokeAsmImportRow>(TargetFolder);
            var doc = TextDocs.parse(src).Require();
            var data = doc.Rows;
            var count = data.Length;
            var buffer = alloc<StokeAsmExportRow>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                var export = default(StokeAsmExportRow);
                var import = default(StokeAsmImportRow);
                Fill(skip(data,i), ref import);
                Fill(import, ref seek(dst,i));
            }

            Emit(buffer);
            return buffer;
        }

        void Emit(Index<StokeAsmExportRow> src)
        {
            var dst = Wf.Db().Table<StokeAsmExportRow>(TargetFolder);
            var flow = Wf.EmittingTable<StokeAsmExportRow>(dst);
            var count = Tables.emit(src.View, dst);
            Wf.EmittedTable(flow,count);
        }

        static bool mode64(string src)
            => src switch
            {
                "V" => true,
                _ => false
            };

        void Fill(in StokeAsmImportRow src, ref StokeAsmExportRow dst)
        {
            dst.Sequence = src.Sequence;
            dst.OpCode = src.OpCode;
            dst.Instruction = src.Instruction;
            dst.Mode64 = mode64(src.Mode64);
            dst.LegacyMode = src.LegacyMode;
            dst.EncodingKind = src.EncodingKind;
            dst.Properties = src.Properties;
            dst.ImplicitRead = src.ImplicitRead;
            dst.ImplicitWrite = src.ImplicitWrite;
            dst.ImplicitUndef = src.ImplicitUndef;
            dst.Protected = src.Protected;
            dst.Cpuid = src.Cpuid;
            dst.AttMnemonic = src.AttMnemonic;
            dst.Description = src.Description;
        }

        void Fill(in TextRow src, ref StokeAsmImportRow dst, ushort? seq = null)
        {
            var i = 0;
            var cells = src.Cells.View;
            if(seq == null)
                ScalarParser.parse(skip(cells,i++), out dst.Sequence);
            else
                dst.Sequence = seq.Value;
            dst.OpCode = skip(cells, i++);
            dst.Instruction = skip(cells, i++);
            dst.EncodingKind = skip(cells, i++);
            dst.Properties = skip(cells, i++);
            dst.ImplicitRead = skip(cells, i++);
            dst.ImplicitWrite = skip(cells, i++);
            dst.ImplicitUndef = skip(cells, i++);
            dst.Useful = skip(cells, i++);
            dst.Protected = skip(cells, i++);
            dst.Mode64 = skip(cells, i++);
            dst.LegacyMode = skip(cells, i++);
            dst.Cpuid = skip(cells, i++);
            dst.AttMnemonic = skip(cells, i++);
            dst.Preferred = skip(cells, i++);
            dst.Description = skip(cells, i++);
        }

        public Index<AsmMnemonic> Mnemonics()
        {
            var dst = root.hashset<AsmMnemonic>();
            var rows = ImportedStokeRows();
            var count = rows.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                if(AsmParser.mnemonic(row.Instruction, out var monic))
                    dst.Add(monic);
            }
            return dst.ToArray();
        }

        public Index<Name> EncodingKindNames()
        {
            var rows = ImportedStokeRows();
            var count = rows.Length;
            var dst = root.hashset<Name>();
            project(rows, (i,n) => dst.Add(n.EncodingKind));
            return dst.Index().Sort();
        }

        static void project<S,T>(ReadOnlySpan<S> rows, Func<uint,S,T> f)
        {
            var count = rows.Length;
            for(var i=0u; i<count; i++)
                f(i, skip(rows,i));
        }

        public ReadOnlySpan<StokeAsmImportRow> ImportedStokeRows()
        {
            if(ImportRowCount != 0)
                return slice(RowBuffer.View,0, ImportRowCount);
            else
                return ImportStokeRows();
        }

        void Sample(ReadOnlySpan<TextLine> src)
        {
            var count = src.Length;
            var sample = root.min(30,count);
            for(var i=0; i<sample; i++)
                Wf.Row(skip(src,i).Content);
        }

        ReadOnlySpan<StokeAsmImportRow> ImportStokeRows()
        {
            var descriptor = Parts.AsmCatalogs.Assets.StanfordAsmCatalog();
            var content = Resources.utf8(descriptor);
            ByteSize sz = content.Length*2;
            Wf.Status($"Loaded source catalog data of size {sz} bytes");

            var foundheader = false;
            var lines = text.lines(content).View;

            Wf.Status($"Parsing {lines.Length} source catalog lines");

            var count = lines.Length;
            var buffer = RowBuffer.Edit;
            ref var dst = ref first(buffer);
            var j = z16;
            var failed = false;
            for(var i=0; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);
                if(foundheader)
                {
                    var row = default(StokeAsmImportRow);
                    if(line.IsNonEmpty)
                    {
                        if(parse(j, line, ref row))
                            seek(dst, j++) = row;
                        else
                        {
                            failed = true;
                            break;
                        }
                    }
                }
                else
                {
                    if(line.Content.Equals(SourceHeader))
                    {
                        foundheader = true;
                        Wf.Status($"Detected source catalog header with fields: {SourceHeaderFields.FormatList()}");
                    }
                }
            }

            ImportRowCount = j;
            return slice(buffer, 0, ImportRowCount);
        }

        public ReadOnlySpan<StokeAsmImportRow> ImportSource()
        {
            var dst = Wf.Db().Table<StokeAsmImportRow>(TargetFolder);
            var flow = Wf.EmittingTable<StokeAsmImportRow>(dst);
            var imports = ImportedStokeRows();
            var count = Tables.emit(imports, dst);
            Wf.EmittedTable(flow, count);
            return imports;
        }

        public void Emit(ReadOnlySpan<AsmFormExpr> src)
        {
            AsmFormPipe.create(Wf).Emit(src, Db.Table<AsmFormRecord>(TargetFolder));
        }

        /// <summary>
        /// Retrieves the forms present in the catalog
        /// </summary>
        public ReadOnlySpan<AsmFormExpr> KnownFormExpressions()
        {
            var imported = ImportedStokeRows();
            var count = imported.Length;
            var buffer = span<AsmFormExpr>(count);
            var j=0u;
            var k=0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(imported, i);
                var oc = AsmCore.opcode(row.OpCode);
                if(AsmParser.sig(row.Instruction, out var sig))
                    seek(buffer, k++) = AsmCore.form(oc, sig);
                else
                {
                    seek(buffer, k++) = AsmFormExpr.Empty;
                    Wf.Warn($"The opcode row {row.OpCode} could not be parsed");
                }
            }

            return buffer;
        }

        bool parse(ushort seq, in TextLine src, ref StokeAsmImportRow dst)
        {
            if(TextDoc.row(src, SourceFormat, out var row))
            {
                if(row.CellCount == 15)
                {
                    Fill(row, ref dst, (ushort)(seq + 1));
                    return true;
                }
                else
                {
                    Wf.Error($"Row content parse failure: {nameof(row.CellCount)} = {row.CellCount} != 15; Line: {src}");
                    return false;
                }
            }
            else
            {
                Wf.Error($"Row parse failure: {src.Content}");
                return false;
            }
        }

        FS.FolderName TargetFolder
            => FS.folder("asmcat");

        const string SourceHeader = "Opcode	Instruction	Op/En	Properties	Implicit Read	Implicit Write	Implicit Undef	Useful	Protected	64-bit Mode	Compat/32-bit-Legacy Mode	CPUID Feature Flags	AT&T Mnemonic	Preferred 	Description";

        static ReadOnlySpan<string> SourceHeaderFields
            => SourceHeader.Split(AsmCatDelimiter);
    }
}