//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    using F = Asm.AsmOpCodeField;

    [ApiHost]
    public readonly partial struct AsmTables
    {
        public static EnumLiteralNames<Mnemonic> Mnemonics
        {
            [MethodImpl(Inline), Op]
            get => Enums.NameIndex<Mnemonic>();
        }


        public static uint emit(IWfShell wf, AsmRowSet<Mnemonic> src)
        {
            var count = src.Count;
            if(count != 0)
            {
                var dst = wf.Db().Table(AsmRow.TableId, src.Key.ToString());
                var records = span(src.Sequenced);
                var formatter = Formatters.dataset<AsmRowField>();
                var header = Table.header53<AsmRowField>();

                wf.EmittingTable<AsmRow>(dst);
                using var writer = dst.Writer();
                writer.WriteLine(header);
                for(var i=0; i<count; i++)
                {
                    ref readonly var record = ref skip(records,i);
                    var line = AsmRow.format(record, formatter).Render();
                    writer.WriteLine(line);
                }
                wf.EmittedTable<AsmRow>(count, dst);
            }
            return count;
        }

        static ResExtractor Extractor
            => ResExtractor.Service(typeof(Z0.Parts.Asm).Assembly);

        /// <summary>
        /// Searches for an embedded document with a matching identifier and, if found,
        /// returns the first match; otherwise returns an empty document
        /// </summary>
        /// <param name="match">The resource identifier to match</param>
        public static AppResDoc structured(string match)
            => Extractor.MatchDocument(match);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> encode(in AsmSyntaxEncoding src)
            => MemoryMarshal.CreateReadOnlySpan(ref z.edit(src),1).Bytes();

        [Op, MethodImpl(Inline)]
        public static void parse(in AppResDoc specs, Span<AsmOpCodeRow> dst)
        {
            var fields = Enums.literals<F>();
            var src = span(specs.Rows);
            for(var i=0u; i<src.Length; i++)
               parse(skip(src,i), fields, ref seek(dst,i));
        }

        [Op, MethodImpl(Inline)]
        public static Span<AsmOpCodeRow> opcodes(in AppResDoc specs)
        {
            var dst = Spans.alloc<AsmOpCodeRow>(specs.Rows.Length);
            parse(specs, dst);
            return dst;
        }

        [Op]
        static ref readonly AsmOpCodeRow parse(in TextRow src, ReadOnlySpan<AsmOpCodeField> fields, ref AsmOpCodeRow dst)
        {
            ReadOnlySpan<string> cells = src.CellContent;
            var count = length(cells,fields);

            var parser = new AsmFieldParser();
            for(var i=0; i<count; i++)
            {
                ref readonly var cell = ref skip(cells,i);
                ref readonly var field = ref skip(fields,i);
                switch(field)
                {
                    case F.Sequence:
                        parser.Parse(cell, out dst.Sequence);
                        break;
                    case F.Mnemonic:
                        parser.Parse(cell, out dst.Mnemonic);
                        break;
                    case F.OpCode:
                        parser.Parse(cell, out dst.OpCode);
                        break;
                    case F.Instruction:
                        parser.Parse(cell, out dst.Instruction);
                        break;
                    case F.M16:
                        parser.Parse(cell, out dst.M16);
                        break;
                    case F.M32:
                        parser.Parse(cell, out dst.M32);
                        break;
                    case F.M64:
                        parser.Parse(cell, out dst.M64);
                        break;
                    case F.CpuId:
                        parser.Parse(cell, out dst.CpuId);
                        break;
                    case F.CodeId:
                        parser.Parse(cell, out dst.CodeId);
                        break;
                }
            }

            return ref dst;
        }
    }
}