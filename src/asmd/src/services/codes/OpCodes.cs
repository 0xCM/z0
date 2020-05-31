//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;
    using static Memories;
 
    [ApiHost("api")]
    public class OpCodes : IApiHost<OpCodes>
    {
        [Op, MethodImpl(Inline)]
        public static string Lookup1(int index)
            => OpCodeTokens.cb;

        [Op, MethodImpl(Inline)]
        public static ulong Lookup2(int index)
            => OpCodeTokens.First;

        [Op, MethodImpl(Inline)]
        public static AsciCode4 Lookup4()
            => OpCodeTokens.RexㆍW_C4;

        [Op, MethodImpl(Inline)]
        public static OpCodeOperand operand(ulong src, duet index)
            => new OpCodeOperand((ushort)Bits.slice(src, index*16, 16));

        [Op, MethodImpl(Inline)]
        public static ReadOnlySpan<byte> encode(in EncodedOpCode src)
            => MemoryMarshal.CreateReadOnlySpan(ref refs.edit(in src),1).AsBytes();     
        
        public static void encode()
        {
            AppResources.OpCodeSpecs.OnSome(encode).OnNone(() => term.error($"Could not load opcode spec resource"));
        }

        [Op, MethodImpl(Inline)]
        public static void encode(AppResourceDoc specs)
        {
            var parser = OpCodeRecordParser.Service;
            var parsed = parser.Parse(specs);
            var encoded = encode(parsed);

            var lookup = AsciDataLookup.Service;
            var chars = lookup.chars((int)AsciDigitCode.First, (int)AsciDigitCode.Last);
            term.print(chars.ToString());            
        }
 

        [Op, MethodImpl(Inline)]
        public static Span<EncodedOpCode> encode(ReadOnlySpan<OpCodeRecord> src)
        {
            var dst = Spans.alloc<EncodedOpCode>(src.Length);
            for(var i=0; i<src.Length; i++)
                seek(dst,i) = encode(skip(src,i));   

            return dst;
        }

        [Op, MethodImpl(Inline)]
        public static EncodedOpCode encode(in OpCodeRecord src)
        {          
            var inxs = InstructionParser.Service.Parse(new InstructionExpression(src.Instruction));
            var opcode = OpCodeParser.Service.Parse(new OpCodeExpression(src.Expression));
            var encoding = Control.array<byte>();            
            return new EncodedOpCode(opcode, inxs,encoding);            
        }   
   }
}