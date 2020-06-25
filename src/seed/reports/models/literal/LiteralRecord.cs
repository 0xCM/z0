//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using F = LiteralTableField;
    using T = LiteralRecord;

    public readonly struct LiteralRecord : IRecord<F,T>
    {        
        public int Sequence => Index;
        
        public readonly string TypeName;

        public readonly int Index;

        public readonly string Name;

        public readonly string Hex;

        public readonly string BitString;

        public readonly string Description;

        public LiteralRecord(string TypeName, int Index, string Name, string Hex, string BitString, string Description = null)
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
            var formatter = DataFields.formatter<F>(delimiter);
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