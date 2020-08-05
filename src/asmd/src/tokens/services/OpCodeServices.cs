//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0.Tokens;

    using static Konst;
    using static Root;
    using static As;
 
    [ApiHost("opcodes")]
    public readonly struct OpCodeServices
    {                
        public static OpCodeServices Service => default;

        public static TokenModel[] InstructionTokens
            => AsmTokenIndex.Models; 

        [MethodImpl(Inline), Op]
        public static string Meaning(AsmTokenKind token)
            => AsmTokenIndex.Meanings[(int)token];

        [MethodImpl(Inline), Op]
        public static string Identity(AsmTokenKind token)
            => AsmTokenIndex.Identity[(int)token];

        [MethodImpl(Inline), Op]
        public static string Definition(AsmTokenKind token)
            => AsmTokenIndex.Values[(int)token];

        [MethodImpl(Inline)]
        public static OpCodeDataset dataset()
        {
            var doc = OpCodeServices.doc();
            var count = doc.RowCount;
            var records = sys.alloc<OpCodeRecord>(count);
            CommandInfoParser.Service.Parse(doc, records);
            var identifers = sys.alloc<OpCodeIdentifier>(count);
            OpCodeServices.identify(records, identifers);
            return new OpCodeDataset(records,identifers);
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
                dst[i] = OpCodeServices.identity(skip(src,i));
        }

        [Op]
        public static unsafe OpCodeTokens load(ReadOnlySpan<FieldRef> src, OpCodeToken[] dst)
        {
            var buffer = span(dst);
            ref var target = ref head(buffer);
            for(byte i=0; i<src.Length; i++)
            {
                ref readonly var field = ref skip(src,i);
                var sref = field.ToStringRef();
                seek(buffer, i) = new OpCodeToken(i, (AsmOpCodeToken)(i + 1), sref);
            }
            return new OpCodeTokens(dst);            
        }

        [Op]
        public void Partition(in OpCodePartitoner processor, in OpCodePartition handler, ReadOnlySpan<OpCodeRecord> src)
            => processor.Partition(src, handler);

        static FileName OpCodeSpecName 
            => FileName.Define("OpCodeSpecs", FileExtensions.Csv);

        [Op]
        public static AppResourceDoc doc()
            => ResExtractor.Service().ExtractDocument(OpCodeSpecName).Require();

        [Op]
        public OpCodePartition PartitionOpCodes(int seq = 0)
        {
            var dataset = OpCodeServices.dataset();
            var count = dataset.OpCodeCount;
            var records = dataset.Records;
            var handler = OpCodePartition.Create(count);
            var processor = OpCodePartitoner.Create(seq);
            Partition(processor, handler, records);
            return handler;            
        }
        
        [MethodImpl(Inline), Op]
        public AsmCommandGroup group(in asci16 name)
            => new AsmCommandGroup(name);
    
        [MethodImpl(Inline), Op]
        public OpCodeOperand operand(ulong src, uint2 index)
            => new OpCodeOperand((ushort)Bits.slice(src, index*16, 16));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> encode(in EncodedOpCode src)
            => MemoryMarshal.CreateReadOnlySpan(ref As.edit(src),1).Bytes();                     
   }
}