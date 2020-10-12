//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential), Table(TableId, FieldCount)]
    public struct EnumLiteralRow : IComparable<EnumLiteralRow>
    {
        public const string TableId = "enums.literals";

        public const byte FieldCount = 9;

        public static void format(in EnumLiteralRow src, TableFormatter<Fields> dst, bool eol = true)
        {
            dst.Delimit(Fields.PartId, src.PartId);
            dst.Delimit(Fields.TypeId, src.TypeId);
            dst.Delimit(Fields.TypeAddress, src.TypeAddress);
            dst.Delimit(Fields.NameAddress, src.NameAddress);
            dst.Delimit(Fields.TypeName, src.TypeName);
            dst.Delimit(Fields.DataType, src.DataType);
            dst.Delimit(Fields.Index, src.Index);
            dst.Delimit(Fields.ScalarValue, src.ScalarValue);
            dst.Delimit(Fields.Name, src.Name);
            if(eol)
                dst.EmitEol();
        }

        public enum Fields : ushort
        {
            PartId = 10,

            TypeId = 10,

            TypeAddress = 16,

            NameAddress = 16,

            TypeName = 30,

            DataType = 10,

            Index = 10,

            Name = 30,

            ScalarValue = 16,
        }

        public readonly PartId PartId;

        public readonly ClrArtifactKey TypeId;

        public readonly MemoryAddress TypeAddress;

        public readonly MemoryAddress NameAddress;

        public readonly EnumScalarKind DataType;

        public readonly string TypeName;

        public readonly ushort Index;

        public readonly string Name;

        public readonly ulong ScalarValue;

        [MethodImpl(Inline)]
        public EnumLiteralRow(PartId part, Type type,  MemoryAddress address, ushort index, string name, MemoryAddress nameaddress, EnumScalarKind primal, ulong value)
        {
            PartId =  part;
            TypeId = type;
            TypeName = type.Name;
            TypeAddress = address;
            Index = index;
            Name = name;
            NameAddress = nameaddress;
            DataType = primal;
            ScalarValue = value;
        }

        static string Identifier(in EnumLiteralRow src)
            => text.format(RP.SlotDot3, src.PartId.Format(), src.TypeId, src.Index);

        public int CompareTo(EnumLiteralRow src)
            => Identifier(this).CompareTo(Identifier(src));
    }
}