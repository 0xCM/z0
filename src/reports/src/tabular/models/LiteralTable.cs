//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Seed;
    using static Tabular;
    
    using F = LiteralTableField;
    using T = LiteralTable;

    public readonly struct LiteralTable : ITabular<F,T>
    {        
        public static Report<F,T> Report<E>(Func<E,string> descriptor = null)
            where E : unmanaged, Enum
                => new Report<F,T>(Records<E>(descriptor));

        public static LiteralTable[] Records<E>(Func<E,string> descriptor = null)
            where E : unmanaged, Enum
        {
            var f = descriptor ?? (x => string.Empty);
            var literals = Enums.literals<E>();
            var dst = new LiteralTable[literals.Length];            
            var primal = typeof(E).GetEnumUnderlyingType();
            var @base = primal.NumericKeywordNot();
            var typeName = $"{typeof(E).Name}{Chars.Colon}{@base}";        
            var flags = typeof(E).Tagged<FlagsAttribute>();

            for(var i=0; i<dst.Length; i++)
            {
                var literal = literals[i];
                
                var description = f(literal.Value);
                if(string.IsNullOrWhiteSpace(description) && flags)
                    description = literal.Value.ToString();

                var numeric = primal.IsSignedInt() 
                    ? literal.NumericValue<long>().ToString() 
                    : literal.NumericValue<ulong>().ToString();

                dst[i] = new LiteralTable(typeName, literal.Index, literal.Name, numeric,  description);
            }

            return dst;
        }

        [TabularField(F.TypeName)]
        public readonly string TypeName;

        [TabularField(F.Index)]
        public readonly int Index;

        [TabularField(F.Name)]
        public readonly string Name;

        [TabularField(F.Value)]
        public readonly string Value;

        [TabularField(F.Description)]
        public readonly string Description;

        public LiteralTable(string TypeName, int Index, string Name, string Value, string Description = null)
        {
            this.TypeName = TypeName;
            this.Index = Index;
            this.Name = Name;
            this.Value = Value;
            this.Description = Description ?? string.Empty;
        }

        static readonly TabularFormat<F> Format = Tabular.format<F>();
        
        static readonly FieldInfo[] Fields = typeof(LiteralTable).Fields().Public().Instance();
        
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