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
            var parsed = parse(specs);
            var encoded = encode(parsed);

            //POC.RevealLocations();
        }

        static AsmRecordParser Parser => AsmRecordParser.Service;

        
        [Op, MethodImpl(Inline)]
        public static Span<OpCodeRecord> parse(AppResourceDoc specs)
        {
            var src = specs.DataRows;
            var dst = Spans.alloc<OpCodeRecord>(src.Length);
            for(var i=0; i<src.Length; i++)
                parse(skip(src,i), ref seek(dst,i));
            
            return dst;
        }

        [Op, MethodImpl(Inline)]
        public static ref readonly OpCodeRecord parse(string src, ref OpCodeRecord dst)
        {
            Parser.Parse(src, ref dst);
            return ref dst;
        }

        [Op, MethodImpl(Inline)]
        public static Span<EncodedOpCode> encode(ReadOnlySpan<OpCodeRecord> src)
        {
            var dst = Spans.alloc<EncodedOpCode>(src.Length);
            for(var i=0; i<src.Length; i++)
                encode(skip(src,i), out seek(dst,i));   

            return dst;
        }

        [Op, MethodImpl(Inline)]
        public static ref readonly EncodedOpCode encode(in OpCodeRecord src, out EncodedOpCode dst)
        {          
            var inxs = InstructionParser.Service.Parse(new InstructionExpression(src.Instruction));
            var opcode = OpCodeParser.Service.Parse(new OpCodeExpression(src.Expression));
            var encoding = Control.array<byte>();
            dst = new EncodedOpCode(opcode, inxs,encoding);
            return ref dst;
        }
    }
}