//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Linq;

    using static Seed;
    using static Memories;
 
    [ApiHost("opcodes")]
    public readonly struct OpCodeServices : IApiHost<OpCodeServices>
    {                
        public static OpCodeServices Service => default;
        
        [MethodImpl(Inline), Op]
        public void Process(in OpCodeProcessor processor, in OpCodeHandler handler, ReadOnlySpan<OpCodeRecord> src)
            => processor.Process(src,handler);

        [Op]
        public OpCodeHandler ProcessOpCodes(int seq = 0)
        {
            var dataset = OpCodeDataset.Create();
            var count = dataset.OpCodeCount;
            var records = dataset.OpCodeRecords;
            var handler = OpCodeHandler.Create(count);
            var processor = OpCodeProcessor.Create(seq);
            Process(processor, handler, records);
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

        // [MethodImpl(Inline)]
        // public OpCodeSpec Parse(OpCodeExpression src)            
        //     => new OpCodeSpec(src, src.Data.SplitClean(Chars.Space).Map(c => new OpCodePart(c)));

        // [MethodImpl(Inline)]
        // public InstructionSpec Parse(InstructionExpression src)     
        // {       
        //     var mnemonic = src.Data.LeftOf(Chars.Space);
        //     var operands = src.Data.RightOf(Chars.Space).SplitClean(Chars.Comma);
        //     return new InstructionSpec(src, mnemonic, operands);
        // }       

        // [MethodImpl(Inline)]
        // public void GenCode(in OpCodeDataset src)
        // {
        //     ReadOnlySpan<OpCodeRecord> codes = src.OpCodeRecords;
        //     for(var i=0; i<codes.Length; i++)
        //     {
        //         ref readonly var record = ref skip(codes,i);
        //         var opcode = Parse(new OpCodeExpression(record.Expression));                
        //         var inxs = Parse(new InstructionExpression(record.Instruction));
        //     }            
        // }
   }
}