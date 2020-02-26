//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static zfunc;
        
    public readonly struct EncodedOp
    {
        public readonly OpIdentity Id;

        public readonly MethodInfo Source;

        public readonly MemoryAddress Address;

        [MethodImpl(Inline)]
        public static EncodedOp Define(OpIdentity id, MethodInfo src, MemoryAddress address)
            => new EncodedOp(id, src, address);
        
        [MethodImpl(Inline)]
        EncodedOp(OpIdentity id, MethodInfo src, MemoryAddress address)
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