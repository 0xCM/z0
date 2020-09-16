//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using F = AsmOpCodeField;
    using R = AsmOpCodeRow;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct AsmOpCodes
    {
        public static string format(in AsmOpCodeRow src, char delimiter = FieldDelimiter)
            => format(src, Formatters.dataset<F>(delimiter)).ToString();

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

        public static TableSpan<TokenInfo> Tokens
            => AsmTokenIndex.create().Model;

        [MethodImpl(Inline), Op]
        public AsmOpCodeOperand operand(ulong src, uint2 index)
            => new AsmOpCodeOperand((ushort)Bits.slice(src, index*16, 16));

        [MethodImpl(Inline), Op]
        public AsmFxGroup group(in asci16 name)
            => new AsmFxGroup(name);

        /// <summary>
        /// Defines, in a predictable and hopefully meaningful way, a programmatic identifier that designates an op code
        /// </summary>
        /// <param name="src">The source record</param>
        [MethodImpl(Inline), Op]
        public static AsmOpCodeId identity(in AsmOpCodeRow src)
            => new AsmOpCodeId(src.OpCode);

        [MethodImpl(Inline), Op]
        public static void identify(ReadOnlySpan<AsmOpCodeRow> src, Span<AsmOpCodeId> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst[i] = AsmOpCodes.identity(skip(src,i));
        }

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
        public void Partition(in AsmOpCodePartitoner processor, in AsmOpCodeGroup handler, ReadOnlySpan<AsmOpCodeRow> src)
            => processor.Partition(src, handler);

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

        static FilePath CasePath(string name)
            => ShellPaths.Default.AppDataRoot + FileName.define(name);

        static FilePath CasePath(string name, FileExtension ext)
            => ShellPaths.Default.AppDataRoot + FileName.define(name, ext);

        static StreamWriter CaseWriter(string name, FileExtension ext)
            =>  CasePath(name, ext).Writer();

        static StreamWriter CaseWriter(string name)
            =>  CasePath(name).Writer();

        void emit(ReadOnlySpan<AsmFxPattern> src)
        {
            var dstPath = CasePath($"InstructionExpression");
            using var writer = dstPath.Writer();
            writer.WriteLine("Instruction");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }
        }

        public void emit(ReadOnlySpan<AsmOpCodeId> src)
        {
            var dstPath = CasePath($"OpCodeIdentifiers");
            using var writer = dstPath.Writer();
            writer.WriteLine("Identifier");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }
        }

        public void emit(ReadOnlySpan<AsmOpCodeExpression> src)
        {
            var dstPath = CasePath($"OpCodes");
            using var writer = dstPath.Writer();
            writer.WriteLine("OpCode");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }
        }

        public void emit(ReadOnlySpan<MnemonicExpression> src)
        {
            var dstPath = CasePath($"Mnemonics");
            using var writer = dstPath.Writer();
            writer.WriteLine("Mnemonic");
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var id = ref skip(src,i);
                writer.WriteLine(id.Format().PadRight(id.Value.Capacity));
            }
        }

        public void instruction_tokens()
        {
            var opcodes = AsmOpCodes.Tokens.View;
            using var dst = CaseWriter("InstructionTokens", FileExtensions.Csv);
            var header = text.concat($"Identifier".PadRight(20), "| ", "Token".PadRight(20), "| ", "Meaning");
            dst.WriteLine(header);
            for(var i=1; i<opcodes.Length; i++)
            {
                ref readonly var token = ref skip(opcodes,i);
                var line = text.concat(token.Identifier.Format().PadRight(20), "| ", token.Value.Format().PadRight(20), "| ", token.Description);
                dst.WriteLine(line);
            }
        }

        void opcode_tokens()
        {
            var data = AsmOpCodes.dataset();
            var count = data.OpCodeCount;
            var records = data.Entries.View;
            var identifers = data.Identity.View;
            insist(count, records.Length);
            insist(count, identifers.Length);

            var processor = new AsmOpCodePartitoner();
            var handler = AsmOpCodeGroup.Create(count);
            processor.Partition(records, handler);

            emit(handler.Instructions);
            emit(handler.OpCodes);
            emit(handler.Mnemonics);
        }
    }
}