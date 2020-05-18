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
    using static Memories;
    
    using F = LiteralTableField;
    using T = LiteralTable;

    /// <summary>
    /// Defines the fields into which a literal table is partitioned
    /// </summary>
    public enum LiteralTableField : ulong
    {   
        /// <summary>
        /// The defining type, such as an enum or a type that declares constant fields
        /// </summary>
        TypeName = 0 | (32ul << WidthOffset),

        /// <summary>
        /// The declaration order of the literal relative to other literals in the same dataset
        /// </summary>
        Index = 1 | (8ul << WidthOffset),

        /// <summary>
        /// The literal name
        /// </summary>
        Name = 2 | (32ul << WidthOffset),

        /// <summary>
        /// The literal's value in base-16
        /// </summary>
        Hex = 3 | (10ul << WidthOffset), 

        /// <summary>
        /// The literal's bitstring representation
        /// </summary>
        BitString = 3 | (32ul << WidthOffset),

        /// <summary>
        ///  A description of the literal if it exist
        /// </summary>
        Description = 4
    }
    public readonly struct LiteralTable : ITabular<F,T>
    {        
        public static Report<F,T> Report<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum
                => new Report<F,T>(Records<E>(declarer, descriptor));

        public static LiteralTable[] Records<E>(string declarer, Func<E,string> descriptor = null)
            where E : unmanaged, Enum
        {
            var f = descriptor ?? (x => string.Empty);
            var literals = Enums.literals<E>();
            var dst = new LiteralTable[literals.Length];            
            var primal = typeof(E).GetEnumUnderlyingType();
            var flags = typeof(E).Tagged<FlagsAttribute>();
            var baseTag =typeof(E).Tag<NumericBaseAttribute>(); 
            var @base = baseTag.MapValueOrDefault(x => x.Base, NumericBaseKind.D);
            var bitmax = baseTag.MapValueOrDefault(x => x.MaxDigits, (int?)null);
            var hmax = bitmax != null ? bitmax.Value/4 : (int?)null;

            for(var i=0; i<dst.Length; i++)
            {
                var literal = literals[i];
                
                var description = f(literal.Value);
                if(string.IsNullOrWhiteSpace(description) && flags)
                    description = literal.Value.ToString();

                var bs = @base == NumericBaseKind.B ? MultiFormatter.Service.FormatEnum(literal.Value, n2, bitmax) : string.Empty;
                var hex = MultiFormatter.Service.FormatEnum(literal.Value, n16, hmax);
                dst[i] = new LiteralTable(declarer, literal.Index, literal.Name, hex, bs, description);
            }

            return dst;
        }

        [TabularField(F.TypeName)]
        public readonly string TypeName;

        [TabularField(F.Index)]
        public readonly int Index;

        [TabularField(F.Name)]
        public readonly string Name;

        [TabularField(F.Hex)]
        public readonly string Hex;

        [TabularField(F.BitString)]
        public readonly string BitString;

        [TabularField(F.Description)]
        public readonly string Description;

        public LiteralTable(string TypeName, int Index, string Name, string Hex, string BitString, string Description = null)
        {
            this.TypeName = TypeName;
            this.Index = Index;
            this.Name = Name;
            this.Hex = Hex;
            this.BitString = BitString;
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