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

    public enum EnumLiteralRecordField : ushort
    {
        PartId = 10,

        TypeId = 10,

        TypeAddress = 16,

        NameAddress = 16,

        TypeName = 30,

        DataType = 10,

        Index = 10,

        ScalarValue = 16,

        Name = 30,
    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly struct EnumLiteralRecord : IComparable<EnumLiteralRecord>
    {
        public readonly PartId PartId;

        public readonly ArtifactIdentifier TypeId;

        public readonly MemoryAddress TypeAddress;

        public readonly string TypeName;

        public readonly ushort Index;

        public readonly string Name;

        public readonly MemoryAddress NameAddress;

        public readonly EnumScalarKind PrimalKind;

        public readonly ulong ScalarValue;

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => text.format(RenderPatterns.SlotDot3, PartId.Format(), TypeId, Index);
        }

        [MethodImpl(Inline)]
        public EnumLiteralRecord(PartId part, Type type,  MemoryAddress address, ushort index, string name, MemoryAddress nameaddress, EnumScalarKind primal, ulong value)
        {

            PartId =  part;
            TypeId = type;
            TypeName = type.Name;
            TypeAddress = address;
            Index = index;
            Name = name;
            NameAddress = nameaddress;
            PrimalKind = primal;
            ScalarValue = value;
        }

        public int CompareTo(EnumLiteralRecord src)
            => Identifier.CompareTo(src.Identifier);
    }
}