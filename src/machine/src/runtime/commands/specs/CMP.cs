//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static HexCodes;
    using static Seed;
    using static Memories;

    using S = System.ReadOnlySpan<char>;

    partial class Commands
    {
        [Op, MethodImpl(Inline)]
        public static S cmp1() 
            => default;

        [Op, MethodImpl(Inline)]
        public static Vector128<byte> EncodeCmp()
        {
            var spec = new OpCodeSpec(HexKind.x38, 
                    (byte)OpCodeOption.ﾉr, 
                    OperatingMode.All, 
                    Bits.concat((ushort)RmOpKind.rm8,((ushort)RegOpKind.r8))
                    );
            
            return Unsafe.As<OpCodeSpec,Fixed128>(ref spec).Content.AsByte();                        
        }


        static unsafe void ExtractPOC()
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

            AddressFormatter.Format(offsets);


        }

        

        public static unsafe void Extract()
        {
            const byte EOL = ((ushort)SymNotKind.ተ >> 8);
            

            var resource = OpCodeLiterals.Resource;

            var data = resource.FormatHex().BlockPartition(80, Chars.Eol);
            term.print(data);


            ref readonly var src = ref head(resource);
            ref readonly var current = ref src;
            ref readonly var next = ref skip(current,1);

            var specs = list<OpCodeSpec>();
            Span<byte> buffer = stackalloc byte[255];
            var j = 0;
            
            for(var i=0; i<resource.Length; i+=2)
            {
                current = ref skip(src, i);
                next = ref skip(src, i + 1);
                
                if(j == buffer.Length - 1 || next == EOL)
                {
                    var spec = OpCodeSpec.From(buffer);
                    specs.Add(spec);
                    buffer.Clear();
                } 
                else 
                    buffer[j++] = current;            
            }
        }

        public readonly struct OpCodeLiterals
        {            
            public const char CodeSep = (char)SymNotKind.ተ;

            public const char PartSep = Chars.Pipe;            

            
            public static ReadOnlySpan<byte> Resource
                => CharData.AsBytes();

            public static S CharData 
                => Cmp;

            public const string Cmp = 
                Cmpᐸrm8ㆍr8ᐳ + Cmpᐸrm16ㆍr16ᐳ + Cmpᐸrm32ㆍr32ᐳ + Cmpᐸrm64ㆍr64ᐳ + Cmpᐸr8ㆍrm8ᐳ + 
                Cmpᐸr16ㆍrm16ᐳ + Cmpᐸr32ㆍrm32ᐳ + Cmpᐸalㆍimm8ᐳ + Cmpᐸeaxㆍimm32ᐳ + Cmpᐸraxㆍimm32ᐳ + 
                Cmpᐸaxㆍimm16ᐳ + Cmpᐸrm64ㆍimm32ᐳ + Cmpᐸrm64ㆍimm8ᐳ;

            public const string Cmpᐸrm8ㆍr8ᐳ =      "38 /r           | r/m8, r8         | 01110000 ተ";                        
            public const string Cmpᐸrm16ㆍr16ᐳ =    "39 /r           | r/m16, r16       | 01110000 ተ";            
            public const string Cmpᐸrm32ㆍr32ᐳ =    "39 /r           | r/m32, r32       | 01110000 ተ";            
            public const string Cmpᐸrm64ㆍr64ᐳ =    "REX.W 39 /r     | r/m64, r64       | 01110000 ተ";            
            public const string Cmpᐸr8ㆍrm8ᐳ =      "3A /r           | r8, r/m8         | 01110000 ተ";                    
            public const string Cmpᐸr16ㆍrm16ᐳ =    "3B /r           | r16, r/m16       | 01110000 ተ";            
            public const string Cmpᐸr32ㆍrm32ᐳ =    "3A /r           | r32, r/m32       | 01110000 ተ";            
            public const string Cmpᐸr64ㆍrm64ᐳ =    "REX.W 3B /r     | r64, r/m64       | 01000000 ተ";            
            public const string Cmpᐸalㆍimm8ᐳ =     "3C ib           | AL, imm8         | 01110000 ተ";        
            public const string Cmpᐸeaxㆍimm32ᐳ =   "3D id           | EAX, imm32       | 01110000 ተ";            
            public const string Cmpᐸraxㆍimm32ᐳ =   "REX.W 3D id     | RAX, imm32       | 01000000 ተ";            
            public const string Cmpᐸaxㆍimm16ᐳ =    "3D iw           | AX, imm16        | 1110000 ተ";            
            public const string Cmpᐸrm64ㆍimm32ᐳ = "REX.W 81 /7 id   | r/m64, imm32     | 01000000 ተ";
            public const string Cmpᐸrm64ㆍimm8ᐳ =  "REX.W 83 /7 ib   | r/m64, imm8       | 01000000 ተ";

        }
    }


	/// <summary>
	/// Operand kind
	/// </summary>
	public enum OpKind : byte 
    {
		/// <summary>
		/// No operand
		/// </summary>
		None,
        
	}

 

}