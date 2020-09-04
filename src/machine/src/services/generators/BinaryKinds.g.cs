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

    using static Konst;

    public class BinaryKindGenerator : CodeGenerator
    {
        public static BinaryKindGenerator Create(uint max = 0xFF)
            => new BinaryKindGenerator
            {
                MaxValue = max,
            };

        BitFormatter<byte> Formatter {get;}
            = Formatters.bits<byte>();

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
        static byte nlz(uint src)
            => (byte)Lzcnt.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        static byte effwidth(uint src)
            => (byte)(32 - nlz(src));

        byte MaxBitCount
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
            line(l0("namespace", Space, Namespace), dst);
            line(l0(LBrace), dst);
            line(concat(Level1,Access, Space, spaced(TypeKind, TypeName, Chars.Colon, BaseType)), dst);
            line(l1(LBrace), dst);
            lines(Literals(), dst);
            line(l1(RBrace), dst);
            line(l0(RBrace), dst);

            return dst.ToString();
        }

        IEnumerable<string> Literals()
        {
            for(var i=0; i<=MaxValue; i++)
            {
                yield return l2(Literal(LiteralName((byte)i), LiteralValue((byte)i)), Chars.Comma);
                yield return EmptyString;
            }
        }

        string LiteralName(byte value)
            => text.concat(AsciLetterLo.b, Formatter.Format(value, BitFormatter.limited(MaxBitCount, MaxBitCount)));

        string LiteralValue(byte value)
            => text.concat("0b", Formatter.Format(value, BitFormatter.limited(MaxBitCount, MaxBitCount)));

        string Literal(string Name, string Value)
            => text.assign(Name, Value);
    }
}