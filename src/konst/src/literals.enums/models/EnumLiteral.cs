//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = EnumLiteralField;

    public struct EnumLiteral
    {
        public string TypeName;

        public uint Index;

        public string Name;

        public string Hex;

        public string BitString;

        public string Description;

        [MethodImpl(Inline)]
        public EnumLiteral(string type, uint index, string name, string hex, string bits, string description)
        {
            TypeName = type;
            Index = index;
            Name = name;
            Hex = hex;
            BitString = bits;
            Description = description ?? EmptyString;
        }

        public string DelimitedText(char delimiter)
        {
            var formatter = Table.formatter<F>(delimiter);
            formatter.Append(F.TypeName, TypeName);
            formatter.Delimit(F.Index, Index);
            formatter.Delimit(F.Name, Name);
            formatter.Delimit(F.Hex, Hex);
            formatter.Delimit(F.BitString, BitString);
            formatter.Delimit(F.Description, Description);
            return formatter.ToString();
        }

        public override string ToString()
            => DelimitedText(FieldDelimiter);
    }
}