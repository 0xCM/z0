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
    /// Defines the address of an identififed member operation
    /// </summary>
    public readonly struct OpAddress
    {
        public readonly OpIdentity Id;

        public readonly MethodInfo Source;

        public readonly MemoryAddress Address;

        [MethodImpl(Inline)]
        public static OpAddress Define(OpIdentity id, MethodInfo src, MemoryAddress address)
            => new OpAddress(id, src, address);
        
        [MethodImpl(Inline)]
        OpAddress(OpIdentity id, MethodInfo src, MemoryAddress address)
        {
            this.Id = id;
            this.Source = src;
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