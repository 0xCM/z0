//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Seed;
    using static Memories;
    
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

        static readonly TabularFormat<F> Format = Tabular.format<F>();
        
        static readonly FieldInfo[] Fields = typeof(LiteralRecord).Fields().Public().Instance();
        
        static int FieldCount => Math.Min(Format.FieldCount, Fields.Length);

        public string DelimitedText(char delimiter)
        {
            var formatter = FieldFormatter<F>.Service;
            for(var i=0; i<FieldCount; i++)
                formatter.DelimitField(Format[i].Specifier, Fields[i].GetValue(this));
            return formatter.ToString();
        }
    }
}