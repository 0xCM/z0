//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
     
    using static Memories;
    using static Seed;

    public class BinaryKindGenerator : CodeGenerator
    {
        public static BinaryKindGenerator Create(uint max = 0xFF)
            => new BinaryKindGenerator
            {
                MaxValue = max,
            };

        BitFormatter<byte> Formatter {get;}
            = BitFormatter.create<byte>();

        public string Namespace {get;}
            = "Z0";

        public string BaseType {get;} 
            = "byte";

        public string Access {get;} 
            = "public";

        public string TypeKind {get;}
            = "enum";

        public string RootName {get;}
            = "BinaryKind";

        public uint MaxValue {get; set;}
            = 0xFF;

        [MethodImpl(Inline)]
        static int nlz(uint src)
            => (int)Lzcnt.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        static int effwidth(uint src)
            => 32 - nlz(src);

        int MaxBitCount 
            => effwidth(MaxValue);

        public string TypeName 
        {
            get
            {
                if(MaxValue == 0xFF)
                    return RootName;
                else
                    return RootName + MaxBitCount;
            }
        }

        public override string Generate()
        {
            var dst = text.build();
            dst.Append(FileHeader);
            line(l0("namespace", space, Namespace), dst);
            line(l0(lbrace), dst);
            line(concat(level1,Access, space, spaced(TypeKind, TypeName, Chars.Colon, BaseType)), dst);
            line(l1(lbrace), dst);
            lines(Literals(), dst);
            line(l1(rbrace), dst);
            line(l0(rbrace), dst);

            return dst.ToString();
        }
        
        IEnumerable<string> Literals()
        {
            for(var i=0; i<=MaxValue; i++)
            {
                yield return l2(Literal(LiteralName((byte)i), LiteralValue((byte)i)), comma);
                yield return blank;
            }
        }

        string LiteralName(byte value)
            => concat(Letters.b, Formatter.Format(value, BitFormatConfig.Limited(MaxBitCount,MaxBitCount)));

        string LiteralValue(byte value)
            => concat("0b", Formatter.Format(value, BitFormatConfig.Limited(MaxBitCount,MaxBitCount)));

        string Literal(string Name, string Value) 
            => assign(Name, Value);
    }
}