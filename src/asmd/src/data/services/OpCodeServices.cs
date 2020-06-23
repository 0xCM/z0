//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static Root;
    using static As;
 
    [ApiHost("opcodes")]
    public readonly struct OpCodeServices : IApiHost<OpCodeServices>
    {                
        public static OpCodeServices Service => default;

        [Op]
        public static unsafe OpCodeTokens load(ReadOnlySpan<FieldRef> src, OpCodeToken[] dst)
        {
            var buffer = span(dst);
            ref var target = ref head(buffer);
            for(byte i=0; i<src.Length; i++)
            {
                ref readonly var field = ref skip(src,i);
                var data = cover(field.C16, field.Location.Length);
                var value = asci8.Null;
                asci.encode(data, out value);
                seek(buffer, i) = new OpCodeToken(i, (OpCodeTokenKind)i, value);
            }
            return new OpCodeTokens(dst);            
        }

        public static unsafe OpCodeTokens tokens()
            => load(FieldCapture.Service.StringLiterals(typeof(OpCodeTokenKinds)),alloc<OpCodeToken>(OpCodeTokenKinds.Count));

        [MethodImpl(Inline), Op]
        public void Partition(in OpCodePartitoner processor, in OpCodePartition handler, ReadOnlySpan<OpCodeRecord> src)
            => processor.Partition(src, handler);

        [Op]
        public OpCodePartition PartitionOpCodes(int seq = 0)
        {
            var dataset = OpCodeDataset.Create();
            var count = dataset.OpCodeCount;
            var records = dataset.OpCodeRecords;
            var handler = OpCodePartition.Create(count);
            var processor = OpCodePartitoner.Create(seq);
            Partition(processor, handler, records);
            return handler;            
        }
        
        [MethodImpl(Inline), Op]
        public AsmCommandGroup group(in asci16 name)
            => new AsmCommandGroup(name);
    
        [MethodImpl(Inline), Op]
        public OpCodeOperand operand(ulong src, duet index)
            => new OpCodeOperand((ushort)Bits.slice(src, index*16, 16));

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> encode(in EncodedOpCode src)
            => MemoryMarshal.CreateReadOnlySpan(ref refs.edit(in src),1).Bytes();                     
   }
}