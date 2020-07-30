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

    public readonly struct EnumLiteralRecord : ITabular<EnumLiteralField,EnumLiteralRecord>, IComparable<EnumLiteralRecord>
    {
        public readonly PartId PartId;

        public readonly ArtifactIdentity TypeId;

        public readonly ushort Index;

        public readonly string Name;
        
        public readonly EnumScalarKind DataType;

        public readonly ulong ScalarValue;

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => text.format("{0}.{1}.{2}", PartId.Format(), TypeId, Index);
        }

        [MethodImpl(Inline)]
        public EnumLiteralRecord(PartId part, ArtifactIdentity type, ushort index, string name, EnumScalarKind primal, ulong value)
        {
            PartId =  part;
            TypeId = type;
            Index = index;
            Name = name;
            DataType = primal;
            ScalarValue = value;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Name);
        }

        public string Format()
            => Format(FieldDelimiter);

        public string Format(char delimiter)
        {
            var formatter = TableFormatters.create<F>(delimiter);
            formatter.Append(F.PartId, PartId);
            formatter.Delimit(F.TypeId, TypeId);
            formatter.Append(F.Index, Index);
            formatter.Append(F.Name, Name);
            formatter.Delimit(F.DataType, DataType);                
            formatter.Delimit(F.ScalarValue, ScalarValue);                
            return formatter.Format();
        }

        public int CompareTo(EnumLiteralRecord src)
            => Identifier.CompareTo(src.Identifier);

        public string DelimitedText(char delimiter)
            => Format(delimiter);
        
        public static EnumLiteralRecord Empty 
            => default;
    }
}