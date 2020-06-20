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
 
    [ApiHost("opcodes")]
    public readonly struct OpCodeServices : IApiHost<OpCodeServices>
    {                
        public static OpCodeServices Service => default;
        
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
            => MemoryMarshal.CreateReadOnlySpan(ref refs.edit(in src),1).AsBytes();                     
   }
}