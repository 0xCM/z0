//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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