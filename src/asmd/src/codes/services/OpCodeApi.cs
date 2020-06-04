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
 
    [ApiHost("opcodes")]
    public class OpCodeApi : IApiHost<OpCodeApi>
    {                
        public static Option<AppResourceDoc> resource()
        {
            var extractor = ResExtractor.Service(typeof(OpCodeApi).Assembly);            
            var name = FileName.Define("OpCodeSpecs", FileExtensions.Csv);
            return extractor.ExtractDocument(name);
        }

        public static ReadOnlySpan<OpCodeRecord> records()
        {
            var specs = resource().Require();
            var parser = OpCodeRecordParser.Service;
            return parser.Parse(specs);
        }

        [Op]
        public static ReadOnlySpan<OpCodeIdentifier> identifiers()
        {
            var src = records();
            var count = src.Length;
            var dst =  Spans.alloc<OpCodeIdentifier>(count);
            for(var i=0; i<count; i++)
                seek(dst,i) = identify(skip(src,i));
            return dst;
        }

        [MethodImpl(Inline), Op]
        static string render(Span<char> src)
            => new string(src);

        [MethodImpl(Inline), Op]
        public static string mnemonic(in OpCodeRecord record)
        {
            var length = record.Mnemonic.Length;
            ReadOnlySpan<char> src = record.Mnemonic;
            Span<char> dst = stackalloc char[length];
            head(dst) = head(src);
            for(var i=1; i<length; i++)
                seek(dst,i) = Symbolic.lowercase(skip(src,i));
            return render(dst);
        }
        
        /// <summary>
        /// Defines, in a predictable and hopefully meaningful way, a programmatic identifier that designates an op code
        /// </summary>
        /// <param name="src">The source record</param>
        [MethodImpl(Inline), Op]
        public static OpCodeIdentifier identify(in OpCodeRecord src)
        {
            var part1 = mnemonic(src);

            return new OpCodeIdentifier(part1);
        }

        [Op, MethodImpl(Inline)]
        public static OpCodeSpec parse(OpCodeExpression src)            
            => new OpCodeSpec(src, src.Data.SplitClean(Chars.Space).Map(c => new OpCodePart(c)));

        [Op, MethodImpl(Inline)]
        public static InstructionSpec parse(InstructionExpression src)     
        {       
            var mnemonic = src.Data.LeftOf(Chars.Space);
            var operands = src.Data.RightOf(Chars.Space).SplitClean(Chars.Comma);
            return new InstructionSpec(src,mnemonic,operands);
        }

        [Op, MethodImpl(Inline)]
        public static void generate(AppResourceDoc specs)
        {
            var parser = OpCodeRecordParser.Service;
            var parsed = parser.Parse(specs);
            var count = parsed.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(parsed,i);
                var opcode = parse(new OpCodeExpression(record.Expression));                
                var inxs = parse(new InstructionExpression(record.Instruction));
            }            
        }

        [MethodImpl(Inline)]
        static MemoryAddress address(string src)
            => location(head(span(src)));            
        
        static ArraySpan<TextResource<OpCodeToken>> OCT()
        {
            ArraySpan<MemoryAddress> locations = typeof(OpCodeTokenText).LiteralFieldValues<string>().Map(address);
            ArraySpan<TextResource<OpCodeToken>> dst = new TextResource<OpCodeToken>[locations.Length];
            for(var i=0; i<locations.Length; i++)
            {
                var address = locations[i];
                var value = Spans.cast<char>(memory.read<byte>(address, 0xA)).ToString();
                dst[i] = new TextResource<OpCodeToken>((OpCodeToken)(i + 1), address, value);            
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
                dst.AppendLine($"{t.Location} | {t.Identifier} | {t.Content}");
            }            

            return dst.ToString();

        }

        [Op, MethodImpl(Inline)]
        public static OpCodeOperand operand(ulong src, duet index)
            => new OpCodeOperand((ushort)Bits.slice(src, index*16, 16));

        [Op, MethodImpl(Inline)]
        public static ReadOnlySpan<byte> encode(in EncodedOpCode src)
            => MemoryMarshal.CreateReadOnlySpan(ref refs.edit(in src),1).AsBytes();                     
   }
}