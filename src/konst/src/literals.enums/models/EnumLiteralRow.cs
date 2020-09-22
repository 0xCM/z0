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

    [StructLayout(LayoutKind.Sequential)]
    public struct EnumLiteralRow : IComparable<EnumLiteralRow>
    {
        public readonly PartId PartId;

        public readonly ClrArtifactKey TypeId;

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
        public EnumLiteralRow(PartId part, Type type,  MemoryAddress address, ushort index, string name, MemoryAddress nameaddress, EnumScalarKind primal, ulong value)
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

        public int CompareTo(EnumLiteralRow src)
            => Identifier.CompareTo(src.Identifier);
    }
}