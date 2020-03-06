//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
        
    /// <summary>
    /// Identifies a member that defines an operation and its location in memory
    /// </summary>
    public readonly struct LocatedMember : IAddressable
    {
        public readonly OpIdentity Id;

        public readonly MethodInfo Member;

        public MemoryAddress Address {get;}

        [MethodImpl(Inline)]
        public static LocatedMember Define(OpIdentity id, MethodInfo src, MemoryAddress address)
            => new LocatedMember(id, src, address);
        
        [MethodImpl(Inline)]
        LocatedMember(OpIdentity id, MethodInfo src, MemoryAddress address)
        {
            this.Id = id;
            this.Member = src;
            this.Address = address;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out OpIdentity id, out MemoryAddress address)
        {
            id = Id;
            address = Address;
        }
    }
}