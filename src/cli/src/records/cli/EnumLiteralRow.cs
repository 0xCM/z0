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

    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct EnumLiteralRow : IComparable<EnumLiteralRow>, IRecord<EnumLiteralRow>
    {
        public const string TableId = "enums.literals";

        public enum Fields : ushort
        {
            Component = 10,

            TypeId = 10,

            TypeAddress = 16,

            NameAddress = 16,

            TypeName = 30,

            DataType = 10,

            Index = 10,

            Name = 30,

            ScalarValue = 16,
        }

        public string Component;

        public CliKey TypeId;

        public MemoryAddress TypeAddress;

        public MemoryAddress NameAddress;

        public EnumScalarKind DataType;

        public string TypeName;

        public ushort Index;

        public string Name;

        public ulong ScalarValue;

        [MethodImpl(Inline)]
        public EnumLiteralRow(string part, Type type,  MemoryAddress address, ushort index, string name, MemoryAddress nameaddress, EnumScalarKind primal, ulong value)
        {
            Component =  part;
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
            => text.format(RP.SlotDot3, src.Component, src.TypeId, src.Index);

        public int CompareTo(EnumLiteralRow src)
            => Identifier(this).CompareTo(Identifier(src));
    }
}