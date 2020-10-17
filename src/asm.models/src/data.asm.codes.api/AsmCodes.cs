//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;
    using System.IO;

    using static Konst;
    using static z;

    using F = AsmOpCodeField;

    [ApiHost(ApiNames.AsmCodes, true)]
    public readonly struct AsmCodes
    {
        public static void emit()
        {
            var data = AsmCodes.dataset();
            var count = data.OpCodeCount;
            var records = data.Entries.View;
            var identifers = data.Identity.View;
            insist(count, records.Length);
            insist(count, identifers.Length);

            var processor = new AsmOpCodePartitoner();
            var handler = AsmOpCodeGroup.Create(count);
            processor.Partition(records, handler);

            AsmCodes.emit(handler.Instructions);
            AsmCodes.emit(handler.OpCodes);
            AsmCodes.emit(handler.Mnemonics);
        }

        /// <summary>
        /// Emits embedded opcode resources to a file
        /// </summary>
        /// <param name="dst">The target path</param>
        [Op]
        public static void emit(FS.FilePath dst)
            => emit(AsmCodes.dataset(), dst);

        public static void emit(ReadOnlySpan<TokenInfo> src, FS.FilePath dst)
        {
            var count = src.Length;
            using var writer = dst.Writer();
            var header = text.concat($"Identifier".PadRight(20), "| ", "Token".PadRight(20), "| ", "Meaning");
            writer.WriteLine(header);
            for(var i=1; i<count; i++)
            {
                ref readonly var token = ref skip(src,i);
                var line = text.concat(token.Identifier.Format().PadRight(20), "| ", token.Value.Format().PadRight(20), "| ", token.Description);
                writer.WriteLine(line);
            }
        }

       [Op]
        public static void emit(in AsmOpCodeDataset src, FS.FilePath dst)
        {
            var records = src.Entries.View;
            var count = src.OpCodeCount;
            var formatter = formatter<AsmOpCodeField>();
            using var writer = dst.Writer();
            writer.WriteLine(formatter.HeaderText);
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                writer.WriteLine(emit(record,formatter).Render());
            }
        }

       public static void emit(ReadOnlySpan<AsmInstructionPattern> src)
        {
            emit(src, AsmCodes.CasePath($"InstructionExpression"));
        }

        public static void emit(ReadOnlySpan<AsmInstructionPattern> src, FS.FilePath dstPath)
        {
            using var writer = dstPath.Writer();
            writer.WriteLine("Instruction");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }
        }

        public static void emit(ReadOnlySpan<AsmOpCodePattern> src)
        {
            var dstPath = AsmCodes.CasePath($"OpCodeIdentifiers");
            using var writer = dstPath.Writer();
            writer.WriteLine("Identifier");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }
        }

        public static void emit(ReadOnlySpan<AsmOpCodeExpression> src)
        {
            var dstPath = AsmCodes.CasePath($"OpCodes");
            using var writer = dstPath.Writer();
            writer.WriteLine("OpCode");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }
        }

        public static void emit(ReadOnlySpan<MnemonicExpression> src)
        {
            var dstPath = AsmCodes.CasePath($"Mnemonics");
            using var writer = dstPath.Writer();
            writer.WriteLine("Mnemonic");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }
        }

        [Op]
        public AsmOpCodeGroup partition()
        {
            var dataset = AsmCodes.dataset();
            var count = dataset.OpCodeCount;
            var handler = new AsmOpCodeGroup((uint)count);
            var processor = new AsmOpCodePartitoner();
            AsmCodes.partition(processor, handler, dataset.Entries.View);
            return handler;
        }

        [MethodImpl(Inline), Op]
        public static uint partition(ReadOnlySpan<AsmOpCodeRow> src, in AsmOpCodeGroup handler)
        {
            var count = src.Length;
            var s0 = 0u;
            for(var i=s0; i<count; i++)
                partition(skip(src,i), handler, ref s0);

            return s0;
        }

        [MethodImpl(Inline), Op]
        static void partition(in AsmOpCodeRow src, in AsmOpCodeGroup handler, ref uint s0)
        {
            process(src, handler, ref s0);
            s0++;
        }

        [MethodImpl(Inline), Op]
        static void process(in AsmOpCodeRow src, in AsmOpCodeGroup handler, ref uint s0)
        {
            process(AsmExpressions.opcode(src), handler, s0);
            process(AsmExpressions.fx(src), handler, s0);
            process(AsmExpressions.mnemonic(src), handler, s0);
            process(AsmExpressions.cpuid(src), handler, s0);
        }

        [MethodImpl(Inline), Op]
        static void process(AsmOperatingMode src, in AsmOpCodeGroup handler, ref uint seq)
        {
            handler.Include(seq, src);
        }

        [MethodImpl(Inline), Op]
        static void process(in AsmInstructionPattern src, in AsmOpCodeGroup handler, uint seq)
        {
            handler.Include(seq, src);
        }

        [MethodImpl(Inline), Op]
        static void process(in AsmOpCodeExpression src, in AsmOpCodeGroup handler, uint seq)
        {
            handler.Include(seq, src);
        }

        [MethodImpl(Inline), Op]
        static void process(in MnemonicExpression src, in AsmOpCodeGroup handler, uint seq)
        {
            handler.Include(seq, src);
        }

        [MethodImpl(Inline), Op]
        static void process(in CpuidExpression src, in AsmOpCodeGroup handler, uint seq)
        {
            handler.Include(seq, src);
        }

        [Op]
        public static void partition(in AsmOpCodePartitoner processor, in AsmOpCodeGroup handler, ReadOnlySpan<AsmOpCodeRow> src)
            => processor.Partition(src, handler);

        public static TableSpan<TokenInfo> Tokens
            => AsmTokenIndex.create().Model;

        [MethodImpl(Inline), Op]
        public AsmOpCodeOperand operand(ulong src, uint2 index)
            => new AsmOpCodeOperand((ushort)Bits.slice(src, index*16, 16));


        [Op]
        public static AsmSymbols symbols()
        {
            var mnemonics = Symbolic.cover<Mnemonic,ushort>();
            var opcodes = AsmCodes.dataset();
            var registers = Symbolic.cover<RegisterKind,uint>();
            return new AsmSymbols(mnemonics, registers, opcodes);
        }

        [MethodImpl(Inline), Op]
        public static AsmOpCodePart part(asci8 src)
            => new AsmOpCodePart(src);

        [MethodImpl(Inline), Op]
        public static AsmOpCodeExpression from(asci32 src)
            => new AsmOpCodeExpression(src);

        [MethodImpl(Inline), Op]
        public static AsmOpCodeExpression from(char[] src)
        {
            var dst = asci32.Null;
            asci.encode(src, out dst);
            return from(dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmOpCodeExpression from(string src)
        {
            var dst = asci32.Null;
            asci.encode(src, out dst);
            return from(dst);
        }

        public static string format(in AsmOpCodeRow src, char delimiter = FieldDelimiter)
            => format(src, Formatters.dataset<F>(delimiter)).ToString();

        public static EnumLiteralNames<Mnemonic> Mnemonics
        {
            [MethodImpl(Inline), Op]
            get => Enums.NameIndex<Mnemonic>();
        }

        static ResExtractor Extractor
            => ResExtractor.Service(typeof(Z0.Parts.AsmModels).Assembly);

        /// <summary>
        /// Searches for an embedded document with a matching identifier and, if found,
        /// returns the first match; otherwise returns an empty document
        /// </summary>
        /// <param name="match">The resource identifier to match</param>
        public static AppResourceDoc structured(string match)
            => Extractor.MatchDocument(match);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> encode(in AsmSyntaxEncoding src)
            => MemoryMarshal.CreateReadOnlySpan(ref z.edit(src),1).Bytes();

        [Op, MethodImpl(Inline)]
        public static void parse(in AppResourceDoc specs, Span<AsmOpCodeRow> dst)
        {
            var fields = Enums.literals<F>();
            var src = span(specs.Rows);
            for(var i=0u; i<src.Length; i++)
               parse(skip(src,i), fields, ref seek(dst,i));
        }

        [Op, MethodImpl(Inline)]
        public static Span<AsmOpCodeRow> opcodes(in AppResourceDoc specs)
        {
            var dst = Spans.alloc<AsmOpCodeRow>(specs.Rows.Length);
            parse(specs, dst);
            return dst;
        }

        [Op]
        static ref readonly AsmOpCodeRow parse(in TextRow src, ReadOnlySpan<F> fields, ref AsmOpCodeRow dst)
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


        [MethodImpl(Inline)]
        public static DatasetFormatter<T> formatter<T>()
            where T : unmanaged, Enum
                    => Formatters.dataset<T>();

        [Op]
        public static AsmOpCodeDataset dataset()
        {
            var resource = ResExtractor.Service(typeof(Parts.Refs).Assembly).MatchDocument("OpCodeSpecs");
            var count = resource.RowCount;
            var records = sys.alloc<AsmOpCodeRow>(count);
            AsmTables.parse(resource, records);
            var identifers = sys.alloc<AsmOpCodePattern>(count);
            AsmCodes.identify(records, identifers);
            return new AsmOpCodeDataset(records,identifers);
        }

        /// <summary>
        /// Defines, in a predictable and hopefully meaningful way, a programmatic identifier that designates an op code
        /// </summary>
        /// <param name="src">The source record</param>
        [MethodImpl(Inline), Op]
        public static AsmOpCodePattern identity(in AsmOpCodeRow src)
            => new AsmOpCodePattern(src.OpCode);

        [MethodImpl(Inline), Op]
        public static void identify(ReadOnlySpan<AsmOpCodeRow> src, Span<AsmOpCodePattern> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst[i] = identity(skip(src,i));
        }

        public static FS.FilePath CasePath(string name)
            => FS.path((WfPaths.create().AppDataRoot + FileName.define(name)).Name);

        static FS.FilePath CasePath(string name, FileExtension ext)
            => FS.path((WfPaths.create().AppDataRoot + FileName.define(name, ext)).Name);

        static StreamWriter CaseWriter(string name, FileExtension ext)
            =>  CasePath(name, ext).Writer();

        static StreamWriter CaseWriter(string name)
            =>  CasePath(name).Writer();

        [Op]
        public static AsmOpCodeTokens load(ReadOnlySpan<FieldRef> src, AsmOpCodeToken[] dst)
        {
            var buffer = span(dst);
            ref var target = ref first(buffer);
            for(byte i=0; i<src.Length; i++)
            {
                ref readonly var field = ref skip(src,i);
                var sr = field.ToStringRef();
                seek(buffer, i) = new AsmOpCodeToken(i, (AsmOpCodeTokenKind)(i + 1), sr);
            }
            return new AsmOpCodeTokens(dst);
        }

        [Op]
        public static ref readonly DatasetFormatter<F> emit(in AsmOpCodeRow src, in DatasetFormatter<F> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Mnemonic, src.Mnemonic);
            dst.Delimit(F.OpCode, src.OpCode);
            dst.Delimit(F.Instruction, src.Instruction);
            dst.Delimit(F.M16, src.M16);
            dst.Delimit(F.M32, src.M32);
            dst.Delimit(F.M64, src.M64);
            dst.Delimit(F.CpuId, src.CpuId);
            dst.Delimit(F.CodeId, src.CodeId);
            return ref dst;
        }
        [Op]
        public static ref readonly DatasetFormatter<F> format(in AsmOpCodeRow src, in DatasetFormatter<F> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.Mnemonic, src.Mnemonic);
            dst.Delimit(F.OpCode, src.OpCode);
            dst.Delimit(F.Instruction, src.Instruction);
            dst.Delimit(F.M16, src.M16);
            dst.Delimit(F.M32, src.M32);
            dst.Delimit(F.M64, src.M64);
            dst.Delimit(F.CpuId, src.CpuId);
            dst.Delimit(F.CodeId, src.CodeId);
            return ref dst;
        }
    }
}