//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using Z0.Asm;
    using Z0.Tokens;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static MnemonicExpression mnemonicExpr(in AsmOpCodeTable src)
            => new MnemonicExpression(src.Mnemonic);

        [MethodImpl(Inline), Op]
        public static CpuidExpression cpuidExpr(in AsmOpCodeTable src)
            => new CpuidExpression(src.CpuId);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(in AsmOpCodeTable src)
            => new AsmOpCode(src.OpCode);

        [MethodImpl(Inline), Op]
        public static InstructionExpression fxExpr(in AsmOpCodeTable src)
            => new InstructionExpression(src.Instruction);

        public static TableSpan<TokenModel> Tokens
            => AsmTokenIndex.create().Model; 

        [MethodImpl(Inline), Op]
        public AsmOpCodeOperand operand(ulong src, uint2 index)
            => new AsmOpCodeOperand((ushort)Bits.slice(src, index*16, 16));

        [MethodImpl(Inline), Op]
        public AsmFxGroup group(in asci16 name)
            => new AsmFxGroup(name);

        [Op]
        public static AsmOpCodeDataset dataset()
        {
            var resource = ResExtractor.Service(typeof(Parts.Data).Assembly).MatchDocument("OpCodeSpecs");
            var count = resource.RowCount;
            var records = sys.alloc<AsmOpCodeTable>(count);
            AsmTables.parse(resource, records);
            var identifers = sys.alloc<AsmOpCodeId>(count);
            AsmOpCodes.identify(records, identifers);
            return new AsmOpCodeDataset(records,identifers);
        }

        [MethodImpl(Inline), Op]
        static AsmOpCodePartitoner partitioner(uint seq = 0)
            => new AsmOpCodePartitoner((int)seq);

        [Op]
        public AsmOpCodeGroup partition(uint seq = 0)
        {
            var dataset = AsmOpCodes.dataset();
            var count = dataset.OpCodeCount;
            var records = dataset.Records;
            var handler = new AsmOpCodeGroup((uint)count);
            var processor = partitioner(seq);
            Partition(processor, handler, records);
            return handler;            
        }        

        [MethodImpl(Inline), Op]
        public static uint partition(ReadOnlySpan<AsmOpCodeTable> src, in AsmOpCodeGroup handler)
        {
            var count = src.Length;            
            var s0 = 0u;
            for(var i=s0; i<count; i++)
                partition(skip(src,i), handler, ref s0);

            return s0;
        }
        
        [MethodImpl(Inline), Op]
        static void partition(in AsmOpCodeTable src, in AsmOpCodeGroup handler, ref uint s0)
        {
            process(src, handler, ref s0);
            s0++;
        }

        [MethodImpl(Inline), Op]
        static void process(in AsmOpCodeTable src, in AsmOpCodeGroup handler, ref uint s0)
        {
            process(opcode(src), handler, s0);
            process(fxExpr(src), handler, s0);
            process(mnemonicExpr(src), handler, s0);
            process(cpuidExpr(src), handler, s0);
        }

        [MethodImpl(Inline), Op]
        static void process(OperatingMode src, in AsmOpCodeGroup handler, ref uint seq)
        {
            handler.Include(seq, src);        
        }

        [MethodImpl(Inline), Op]
        static void process(in InstructionExpression src, in AsmOpCodeGroup handler, uint seq)
        {
            handler.Include(seq, src);
        }

        [MethodImpl(Inline), Op]
        static void process(in AsmOpCode src, in AsmOpCodeGroup handler, uint seq)
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

        /// <summary>
        /// Defines, in a predictable and hopefully meaningful way, a programmatic identifier that designates an op code
        /// </summary>
        /// <param name="src">The source record</param>
        [MethodImpl(Inline), Op]
        public static AsmOpCodeId identity(in AsmOpCodeTable src)
            => new AsmOpCodeId(src.OpCode);

        [MethodImpl(Inline), Op]
        public static void identify(ReadOnlySpan<AsmOpCodeTable> src, Span<AsmOpCodeId> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst[i] = AsmOpCodes.identity(skip(src,i));
        }

        [Op]
        public static unsafe Asm.AsmOpCodeTokens load(ReadOnlySpan<FieldRef> src, AsmOpCodeToken[] dst)
        {
            var buffer = span(dst);
            ref var target = ref first(buffer);
            for(byte i=0; i<src.Length; i++)
            {
                ref readonly var field = ref skip(src,i);
                var sr = field.ToStringRef();
                seek(buffer, i) = new AsmOpCodeToken(i, (AsmOpCodeTokenKind)(i + 1), sr);
            }
            return new Asm.AsmOpCodeTokens(dst);            
        }

        [Op]
        public void Partition(in AsmOpCodePartitoner processor, in AsmOpCodeGroup handler, ReadOnlySpan<AsmOpCodeTable> src)
            => processor.Partition(src, handler);

        [MethodImpl(Inline), Op]
        public static AsmOpCodePart part(asci8 src)
            => new AsmOpCodePart(src);

        [MethodImpl(Inline), Op]
        public static AsmOpCode from(asci32 src)
            => new AsmOpCode(src);

        [MethodImpl(Inline), Op]
        public static AsmOpCode from(char[] src)
        {
            var dst = asci32.Null;
            asci.encode(src, out dst);
            return from(dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmOpCode from(string src)
        {
            var dst = asci32.Null;
            asci.encode(src, out dst);
            return from(dst);
        }

        static FilePath CasePath(string name)
            => AppPaths.Default.AppDataRoot + FileName.Define(name);

        static FilePath CasePath(string name, FileExtension ext)
            => AppPaths.Default.AppDataRoot + FileName.Define(name, ext);

        static StreamWriter CaseWriter(string name, FileExtension ext)
            =>  CasePath(name, ext).Writer();

        static StreamWriter CaseWriter(string name)
            =>  CasePath(name).Writer();

        void emit(ReadOnlySpan<InstructionExpression> src)
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

        public void emit(ReadOnlySpan<AsmOpCode> src)
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

        public void opcode_reccords()
        {            
            var data = AsmOpCodes.dataset();
            var count = data.OpCodeCount;
            var records = data.Records.ToReadOnlySpan();
            using var writer = CaseWriter("OpCodes");            
            writer.WriteLine(AsmOpCodeTable.FormatHeader());
            for(var i=0; i<records.Length; i++)
                writer.WriteLine(skip(records,i).Format());        
        }

        void opcode_tokens()
        {
            var data = AsmOpCodes.dataset();
            var count = data.OpCodeCount;
            var records = data.Records.ToReadOnlySpan();
            var identifers = data.OpCodeIdentifiers.ToReadOnlySpan();
            insist(count, records.Length);
            insist(count, identifers.Length);

            var processor = partitioner();
            var handler = AsmOpCodeGroup.Create(count);
            processor.Partition(records, handler);

            emit(handler.Instructions);
            emit(handler.OpCodes);
            emit(handler.Mnemonics);
        }
    }
}