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

    public readonly struct ResourceMember<T>
        where T : unmanaged
    {
        public readonly MemberInfo Member {get;}

        public ulong Location {get;}

        public int CellCount {get;}

        public int CellSize => Unsafe.SizeOf<T>();

        public int CellWidth => Unsafe.SizeOf<T>()*8;                    

        public int ByteCount => CellCount*CellSize;

        [MethodImpl(Inline)]        
        public ResourceMember(MemberInfo member, ulong location, int cells)
        {            
            Member = member;
            Location = location;
            CellCount = cells;
        }
    }
}