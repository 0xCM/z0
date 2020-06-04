//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Control;
    using static Seed;
    
    public readonly struct ResourceMember : ITextual
    {
        [MethodImpl(Inline)]
        public static ResourceMember Define(MemberInfo member, ulong location, uint cells, uint bytes)
            => new ResourceMember(member,location,cells,bytes);

        [MethodImpl(Inline)]
        public ResourceMember(MemberInfo member, ulong location, uint cells, uint bytes)
        {
            Member = member;
            Location = location;
            CellCount = cells;
            ByteCount = bytes;
        }

        public readonly MemberInfo Member;

        public readonly ulong Location;

        public readonly uint CellCount;
        
        public readonly uint ByteCount;    

        public uint CellWidth => (ByteCount/CellCount)*8;  

        public string Format()
            => $"{Member.Name} {Location.FormatAsmHex()}[{CellCount}:{CellWidth}w]";
    }
}