//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static HexCodes;
    using static Seed;
    using static Memories;

    using S = System.ReadOnlySpan<char>;

    using SN = SymNotKind;

    class POC
    {

        public const string VEXᛁvvvv = "";
        
        static void Trace(S src)
        {
            Span<char> buffer = stackalloc char[255];
            ref readonly var lead = ref head(src);
            ref readonly var current = ref lead;
            ref var dst = ref head(buffer);

            var j = 0;
            for(var i=0; i<src.Length; i++)   
            {
                current = ref skip(lead, i);
                if(current != Chars.Bang)
                    seek(ref dst,j++) = current;
                else
                {
                    term.print(buffer.ToString());
                    buffer.Clear();            
                }
            }
        }
 
        public static unsafe void Extract_Old()
        {                    

            var resource = OpCodeLiterals.Resource;

            var data = resource.FormatHex().BlockPartition(80, Chars.Eol);
            term.print(data);


            ref readonly var src = ref head(resource);
            ref readonly var current = ref src;
            ref readonly var next = ref skip(current,1);

            var specs = list<EncodedOpCode>();
            Span<ASCI> buffer = stackalloc ASCI[255];
            var j = 0;
            
        }

        public static unsafe void RevealLocations()
        {
            S f0 = OpCodeLiterals.Cmpᐸrm8ㆍr8ᐳ;
            S f1 = OpCodeLiterals.Cmpᐸrm16ㆍr16ᐳ;
            S f2 = OpCodeLiterals.Cmpᐸr32ㆍrm32ᐳ;
            S f3 = OpCodeLiterals.Cmpᐸrm64ㆍimm32ᐳ;

            var count = 4;
            Span<MemoryAddress> dst = new MemoryAddress[count];
            Span<MemoryOffset> offsets = new MemoryOffset[count];
            
            var i=0;

            seek(dst,i++) = location(head(f0));
            seek(dst,i++) = location(head(f1));
            seek(dst,i++) = location(head(f2));
            seek(dst,i++) = location(head(f3));

            i = 0;
            var j=0;
            var @base = head(dst);
            seek(offsets, j++) = MemoryOffsets.from(@base, skip(dst, i++));
            seek(offsets, j++) = MemoryOffsets.from(@base, skip(dst, i++));
            seek(offsets, j++) = MemoryOffsets.from(@base, skip(dst, i++));
            seek(offsets, j++) = MemoryOffsets.from(@base, skip(dst, i++));

            var rendered = AddressFormatter.Format(offsets);
            rendered.Iter(term.print);

        }

        const ASCI CodeTerm = ASCI.Bang;

        const ASCI PartSep = ASCI.Pipe;

        const ASCI Space = ASCI.Space;


        [Op, MethodImpl(Inline)]
        public static int NextOpCode(ReadOnlySpan<ASCI> src, Span<ASCI> dst, ref int i)
        {
            ref readonly var lead = ref skip(src, i);
            ref readonly var current = ref lead;
            var j = 0;
            for(; i<src.Length; i+=2)
            {
                current = ref skip(lead,i);
                
                if(current == CodeTerm)
                    break;

                if(current == Space)
                    continue;
                seek(dst,j++) = current;
            }
            return j;
        }
    }

    public readonly struct OpCodeLiterals
    {            
        public const ASCI CodeTerm = ASCI.Bang;

        public const ASCI PartSep = ASCI.Pipe;

        public const ASCI Space = ASCI.Space;
        
        public static ReadOnlySpan<ASCI> Resource
            => Spans.cast<ASCI>(CharData.AsBytes());

        public static S CharData 
            => Cmp;

        public const string Cmp = 
            Cmpᐸrm8ㆍr8ᐳ + Cmpᐸrm16ㆍr16ᐳ + Cmpᐸrm32ㆍr32ᐳ + Cmpᐸrm64ㆍr64ᐳ + Cmpᐸr8ㆍrm8ᐳ + 
            Cmpᐸr16ㆍrm16ᐳ + Cmpᐸr32ㆍrm32ᐳ + Cmpᐸalㆍimm8ᐳ + Cmpᐸeaxㆍimm32ᐳ + Cmpᐸraxㆍimm32ᐳ + 
            Cmpᐸaxㆍimm16ᐳ + Cmpᐸrm64ㆍimm32ᐳ + Cmpᐸrm64ㆍimm8ᐳ;

        public const string Cmpᐸrm8ㆍr8ᐳ =      "38 /r           | r/m8, r8         | 01110000 !";                        
        public const string Cmpᐸrm16ㆍr16ᐳ =    "39 /r           | r/m16, r16       | 01110000 !";            
        public const string Cmpᐸrm32ㆍr32ᐳ =    "39 /r           | r/m32, r32       | 01110000 !";            
        public const string Cmpᐸrm64ㆍr64ᐳ =    "REX.W 39 /r     | r/m64, r64       | 01110000 !";            
        public const string Cmpᐸr8ㆍrm8ᐳ =      "3A /r           | r8, r/m8         | 01110000 !";                    
        public const string Cmpᐸr16ㆍrm16ᐳ =    "3B /r           | r16, r/m16       | 01110000 !";            
        public const string Cmpᐸr32ㆍrm32ᐳ =    "3A /r           | r32, r/m32       | 01110000 !";            
        public const string Cmpᐸr64ㆍrm64ᐳ =    "REX.W 3B /r     | r64, r/m64       | 01000000 !";            
        public const string Cmpᐸalㆍimm8ᐳ =     "3C ib           | AL, imm8         | 01110000 !";        
        public const string Cmpᐸeaxㆍimm32ᐳ =   "3D id           | EAX, imm32       | 01110000 !";            
        public const string Cmpᐸraxㆍimm32ᐳ =   "REX.W 3D id     | RAX, imm32       | 01000000 !";            
        public const string Cmpᐸaxㆍimm16ᐳ =    "3D iw           | AX, imm16        | 1110000 !";            
        public const string Cmpᐸrm64ㆍimm32ᐳ = "REX.W 81 /7 id   | r/m64, imm32     | 01000000 !";
        public const string Cmpᐸrm64ㆍimm8ᐳ =  "REX.W 83 /7 ib   | r/m64, imm8       | 01000000 !";
    }    
}