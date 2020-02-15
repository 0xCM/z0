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
        [MethodImpl(Inline)]
        public static EncodedOp Define(OpIdentity id, MethodInfo src, MemoryAddress location)
            => new EncodedOp(id, src, location);
        
        [MethodImpl(Inline)]
        EncodedOp(OpIdentity id, MethodInfo src, MemoryAddress location)
        {
            this.Id = id;
            this.Source = src;
            this.Location = location;
        }

        public readonly OpIdentity Id;

        public readonly MethodInfo Source;

        public readonly MemoryAddress Location;

        public void Deconstruct(out OpIdentity id, out MemoryAddress location)
        {
            id = Id;
            location = Location;
        }
    }
}