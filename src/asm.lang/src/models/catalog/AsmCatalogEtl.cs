//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static TextRules;
    using static AsmExpr;
    using static EnumSymbols;

    public sealed class AsmCatalogEtl : WfService<AsmCatalogEtl,AsmCatalogEtl>
    {
        readonly TextDocFormat SourceFormat;

        readonly Index<StokeAsmImportRow> RowBuffer;

        readonly Table<AsmMnemonicCode> MnemonicSymbols;

        const uint MaxRowCount = 2500;

        public AsmCatalogEtl()
        {
            SourceFormat = TextDocFormat.Structured(Chars.Tab);
            RowBuffer = alloc<StokeAsmImportRow>(MaxRowCount);
            MnemonicSymbols = EnumSymbols.table<AsmMnemonicCode>();
        }

        public uint ImportRowCount {get; private set;}

        public ReadOnlySpan<Entry<AsmMnemonicCode>> MnemonicLiterals()
            => MnemonicSymbols.Entries;

        public Index<AsmCatRow> LoadCatalogRows()
        {
            var src = Wf.Db().Table<StokeAsmImportRow>(TargetFolder);
            var doc = TextDocs.parse(src).Require();
            var data = doc.Rows;
            var count = data.Length;
            var buffer = alloc<AsmCatRow>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                var input = default(StokeAsmImportRow);
                Fill(skip(data,i), ref input);
                Fill(input, ref seek(dst,i));
            }
            return buffer;
        }

        void Fill(in StokeAsmImportRow src, ref AsmCatRow dst)
        {
            dst.Sequence = src.Sequence;
            dst.OpCode = AsmExpr.opcode(src.OpCode);
            dst.AttMnemonic = src.AttMnemonic;
            dst.Cpuid = src.Cpuid;
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
            var parser = AsmExprParser.create(Wf);
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                if(parser.ParseMnemonic(row.Instruction, out var monic))
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

        ReadOnlySpan<StokeAsmImportRow> ImportStokeRows()
        {
            var descriptor = Assets.create(Wf).AsmCatalog();
            var content = Resources.utf8(descriptor);
            var srcFormat = TextDocFormat.Structured(Chars.Tab);
            var foundheader = false;
            var lines = Parse.lines(content).View;
            var count = lines.Length;
            var buffer = RowBuffer.Edit;
            ref var dst = ref first(buffer);
            var j = z16;
            for(var i=0; i<count; i++)
            {
                ref readonly var line = ref skip(lines,i);
                if(foundheader)
                {
                    var row = default(StokeAsmImportRow);
                    if(parse(j, line, ref row))
                        seek(dst, j++) = row;
                }
                else
                {
                    if(line.Content.Equals(SourceHeader))
                        foundheader = true;
                }
            }
            ImportRowCount = j;
            return slice(buffer,0, ImportRowCount);

        }

        FS.FolderName TargetFolder => FS.folder("asmcat");

        public ReadOnlySpan<StokeAsmImportRow> TransformSource()
        {
            var dst = Wf.Db().Table<StokeAsmImportRow>(TargetFolder);
            var flow = Wf.EmittingTable<StokeAsmImportRow>(dst);
            var imports = ImportedStokeRows();
            var count = Records.emit(imports, dst, 42);
            Wf.EmittedTable(flow, count);
            return imports;
        }

        public void Emit(ReadOnlySpan<OperationSpec> src)
        {
            var dst = Wf.Db().Table<AsmSpecifierRecord>(TargetFolder);
            var flow = Wf.EmittingTable<AsmSpecifierRecord>(dst);
            var count = Records.emit(src.Map(record), dst, AsmSpecifierWidths);
            Wf.EmittedTable(flow, count);
        }

        public Index<OperationSpec> Denormalize(ReadOnlySpan<OperationSpec> src)
        {
            var count = src.Length;
            var dst = root.list<OperationSpec>(count*2);
            for(var i=0; i<count; i++)
            {
                ref readonly var spec = ref skip(src,i);
                var sig = spec.Sig;
            }

            return dst.ToArray();
        }

        public ReadOnlySpan<OperationSpec> Specifiers()
        {
            var imported = ImportedStokeRows();
            var count = imported.Length;
            var buffer = span<OperationSpec>(count);
            var parser = AsmExprParser.create(Wf);
            var j=0u;
            var k=0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(imported, i);
                var oc = AsmExpr.opcode(row.OpCode);
                if(parser.ParseSig(row.Instruction, out var sig))
                    seek(buffer, k++) = AsmExpr.specifier(row.Sequence, oc, sig);
                else
                {
                    seek(buffer, k++) = OperationSpec.Empty;
                    Wf.Warn($"The opcode row {row.OpCode} could not be parsed");
                }
            }

            return buffer;
        }

        bool parse(ushort seq, in TextLine src, ref StokeAsmImportRow dst)
        {
            if(Parse.row(src, SourceFormat, out var row))
            {
                if(row.CellCount == 15)
                {
                    Fill(row, ref dst, (ushort)(seq + 1));
                    return true;
                }
            }

            return false;
        }

        [MethodImpl(Inline), Op]
        public static AsmSpecifierRecord record(OperationSpec src)
        {
            var dst = new AsmSpecifierRecord();
            dst.Seq = src.Seq;
            dst.Sig = src.Sig;
            dst.Composite = src.Sig.Operands.Any(o => o.IsComposite);
            dst.OpCode = src.OpCode;
            return dst;
        }

        internal static ReadOnlySpan<byte> AsmSpecifierWidths => new byte[]{8,48,12,32};

        const string SourceHeader = "Opcode	Instruction	Op/En	Properties	Implicit Read	Implicit Write	Implicit Undef	Useful	Protected	64-bit Mode	Compat/32-bit-Legacy Mode	CPUID Feature Flags	AT&T Mnemonic	Preferred 	Description";
    }
}