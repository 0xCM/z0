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

    using static Seed;
    using static Memories;
 
    [ApiHost("api")]
    public class OpCodes : IApiHost<OpCodes>
    {
        [Op, MethodImpl(Inline)]
        public static Vector256<ulong> Lookup1()
        {            
            var x0 = (ulong)location(head(span(OpCodeTokens.NE)));
            var x1 = (ulong)location(head(span(OpCodeTokens.NP)));
            var x2 = (ulong)location(head(span(OpCodeTokens.NFx)));
            var x3 = (ulong)location(head(span(OpCodeTokens.REXᕀW)));
            return Vector256.Create(x0,x1,x2,x3);
        }


        [MethodImpl(Inline)]
        static MemoryAddress address(string src)
            => location(head(span(src)));            
        
        [MethodImpl(Inline)]
        static string token(MemoryAddress src)
            => Spans.cast<char>(memory.read<byte>(src, 0xA)).ToString();
            
        static ArraySpan<LiteralToken<OpCodeToken>> OCT()
        {
            ArraySpan<MemoryAddress> locations = typeof(OpCodeTokens).LiteralFieldValues<string>().Map(address);
            ArraySpan<LiteralToken<OpCodeToken>> dst = new LiteralToken<OpCodeToken>[locations.Length];
            for(var i=0; i<locations.Length; i++)
            {
                var address = locations[i];
                dst[i] = new LiteralToken<OpCodeToken>((OpCodeToken)(i + 1), address, token(address));            
            }
            return dst;
        }

        [Op]
        public static unsafe ReadOnlySpan<char> Lookup2()
        {            
            var oct = OCT();
            var dst = text.build();   

            for(var i=0; i<oct.Length; i++)            
            {
                var t = oct[i];
                dst.AppendLine($"{t.Location} | {t.Identifier} | {t.Value}");
            }            

            return dst.ToString();

        }

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