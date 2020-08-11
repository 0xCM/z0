//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    using F = EnumLiteralField;
    using T = EnumLiteral;

    public readonly struct EnumLiteral
    {        
        public int Sequence => (int)Index;
        
        public readonly string TypeName;

        public readonly uint Index;

        public readonly string Name;

        public readonly string Hex;

        public readonly string BitString;

        public readonly string Description;

        public EnumLiteral(string TypeName, uint Index, string Name, string Hex, string BitString, string Description = null)
        {
            this.TypeName = TypeName;
            this.Index = Index;
            this.Name = Name;
            this.Hex = Hex;
            this.BitString = BitString;
            this.Description = Description ?? string.Empty;
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