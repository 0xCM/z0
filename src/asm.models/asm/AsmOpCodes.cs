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

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct AsmOpCodes
    {
        public static TableSpan<TokenModel> Tokens
            => AsmTokenIndex.create().Models; 

        [MethodImpl(Inline), Op]
        public OpCodeOperand operand(ulong src, uint2 index)
            => new OpCodeOperand((ushort)Bits.slice(src, index*16, 16));

        [MethodImpl(Inline), Op]
        public AsmCommandGroup group(in asci16 name)
            => new AsmCommandGroup(name);

        static FileName OpCodeSpecName 
            => FileName.Define("OpCodeSpecs", FileExtensions.Csv);

        [Op]
        public static OpCodeDataset dataset()
        {
            var resource = ResExtractor.Service(typeof(Parts.Data).Assembly).MatcDocument("OpCodeSpecs");
            var count = resource.RowCount;
            var records = sys.alloc<OpCodeRecord>(count);
            AsmTables.parse(resource, records);
            var identifers = sys.alloc<OpCodeIdentifier>(count);
            AsmOpCodes.identify(records, identifers);
            return new OpCodeDataset(records,identifers);
        }

        [MethodImpl(Inline), Op]
        public static AsmOpCodePartitoner partitioner(uint seq = 0)
            => new AsmOpCodePartitoner((int)seq);

        [Op]
        public OpCodePartition partition(uint seq = 0)
        {
            var dataset = AsmOpCodes.dataset();
            var count = dataset.OpCodeCount;
            var records = dataset.Records;
            var handler = new OpCodePartition((uint)count);
            var processor = partitioner(seq);
            Partition(processor, handler, records);
            return handler;            
        }        

        /// <summary>
        /// Defines, in a predictable and hopefully meaningful way, a programmatic identifier that designates an op code
        /// </summary>
        /// <param name="src">The source record</param>
        [MethodImpl(Inline), Op]
        public static OpCodeIdentifier identity(in OpCodeRecord src)
            => new OpCodeIdentifier(src.OpCode);

        [MethodImpl(Inline), Op]
        public static void identify(ReadOnlySpan<OpCodeRecord> src, Span<OpCodeIdentifier> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst[i] = AsmOpCodes.identity(skip(src,i));
        }

        [Op]
        public static unsafe AsmOpCodeTokenIndex load(ReadOnlySpan<FieldRef> src, OpCodeToken[] dst)
        {
            var buffer = span(dst);
            ref var target = ref first(buffer);
            for(byte i=0; i<src.Length; i++)
            {
                ref readonly var field = ref skip(src,i);
                var sr = field.ToStringRef();
                seek(buffer, i) = new OpCodeToken(i, (AsmOpCodeTokenKind)(i + 1), sr);
            }
            return new AsmOpCodeTokenIndex(dst);            
        }

        [Op]
        public void Partition(in AsmOpCodePartitoner processor, in OpCodePartition handler, ReadOnlySpan<OpCodeRecord> src)
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

        void emit(ReadOnlySpan<OpCodeIdentifier> src)
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

        void emit(ReadOnlySpan<AsmOpCode> src)
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

        void emit(ReadOnlySpan<MnemonicExpression> src)
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
            writer.WriteLine(OpCodeRecord.FormatHeader());
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
            var handler = OpCodePartition.Create(count);
            processor.Partition(records, handler);

            emit(handler.Instructions);
            emit(handler.OpCodes);
            emit(handler.Mnemonics);
        }

    }
}