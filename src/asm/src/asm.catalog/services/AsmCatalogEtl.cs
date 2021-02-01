//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    using static Part;
    using static memory;
    using static TextRules;

    public sealed class AsmCatalogEtl : WfService<AsmCatalogEtl,AsmCatalogEtl>
    {
        readonly TextDocFormat SourceFormat;

        readonly Index<StokeAsmImportRow> RowBuffer;

        const uint MaxRowCount = 2500;

        public AsmCatalogEtl()
        {
            SourceFormat = TextDocFormat.Structured(Chars.Tab);
            RowBuffer = alloc<StokeAsmImportRow>(MaxRowCount);
        }

        public uint ImportRowCount {get; private set;}

        public Index<AsmMnemonicExpr> Mnemonics()
        {
            var dst = root.hashset<AsmMnemonicExpr>();
            var rows = ImportedStokeRows();
            var count = rows.Length;
            var parser = AsmExprParser.create(Wf);
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(rows,i);
                var sig = AsmExpr.sig(row.Instruction);
                if(parser.Mnemonic(sig, out var monic))
                    dst.Add(monic);
            }
            return dst.ToArray();
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
            if(Resources.descriptor(Parts.Res.Assembly, ContentNames.AsmCatalog, out var descriptor))
            {
                var content = Resources.utf8(descriptor);
                var srcFormat = TextDocFormat.Structured(Chars.Tab);
                var foundheader = false;
                var lines = Parse.lines(content).View;
                var count = lines.Length;
                var buffer = RowBuffer.Edit;
                ref var dst = ref first(buffer);
                var j = 0u;
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
            else
                return Index<StokeAsmImportRow>.Empty;
        }

        FS.FolderName TargetFolder => FS.folder("asmcat");

        public ReadOnlySpan<StokeAsmImportRow> TransformSource()
        {
            var dst = Wf.Db().Table<StokeAsmImportRow>(TargetFolder);
            var flow = Wf.EmittingTable<StokeAsmImportRow>(dst);
            var imports = ImportedStokeRows();
            var count = Records.emit(imports, dst, 42);
            Wf.EmittedTable<StokeAsmImportRow>(flow, count, dst);
            return imports;
        }

        public ReadOnlySpan<AsmSpecifierExpr> Specifiers()
        {
            var imported = ImportedStokeRows();
            var denormal = span<AsmSpecifierExpr>(imported.Length);
            var j=0u;
            var k=0u;
            for(var i=0; i<imported.Length; i++)
            {
                ref readonly var row = ref skip(imported, i);
                var seq = row.Sequence;
                var oc = AsmExpr.opcode(row.OpCode);
                var sig = AsmExpr.sig(row.Instruction);
                var spec = AsmExpr.specifier((ushort)k,oc,sig);
                seek(denormal,k++) = spec;

                //k += Denormalize(spec, denormal, k);
            }

            return denormal;
        }


        bool parse(uint seq, in TextLine src, ref StokeAsmImportRow dst)
        {
            if(Parse.row(src, SourceFormat, out var row))
            {
                if(row.CellCount == 15)
                {
                    var cells = row.Cells.View;
                    var i = 0;
                    dst.Sequence = (ushort)(seq + 1);
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
                    return true;
                }
            }

            return false;
        }


        public uint Denormalize(AsmSpecifierExpr src, Span<AsmSpecifierExpr> dst, uint offset)
        {
            var index = offset;
            var input = AsmExpr.specifier((ushort)index, src.OpCode, src.Sig);
            var pair = Denormalize(input);
            seek(dst,index++) = pair.Left;
            if(pair.Right.IsNonEmpty)
                seek(dst,index++) = pair.Right;
            return index - offset;
        }

        public Pair<AsmSpecifierExpr> Denormalize(AsmSpecifierExpr src)
        {
            var a0 = AsmSpecifierExpr.Empty;
            var a1 = AsmSpecifierExpr.Empty;
            var sigs = Denormalize(src.Sig);
            return (a0,a1);
        }

        public Pair<AsmSig> Denormalize(AsmSigExpr src)
        {
            var a0 = AsmSig.Empty;
            var a1 = AsmSig.Empty;

            // var operands = src.Operands;
            // var opcount = operands.Count;
            // for(var i=0; i<opcount; i++)
            // {

            // }

            return (a0,a1);
        }

        const string SourceHeader = "Opcode	Instruction	Op/En	Properties	Implicit Read	Implicit Write	Implicit Undef	Useful	Protected	64-bit Mode	Compat/32-bit-Legacy Mode	CPUID Feature Flags	AT&T Mnemonic	Preferred 	Description";
    }
}