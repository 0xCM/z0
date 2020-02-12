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
        
    public readonly struct EncodedMethod
    {
        [MethodImpl(Inline)]
        public static EncodedMethod Define(OpIdentity id, MethodInfo src,  MemoryAddress location)
            => new EncodedMethod(id, src, location);
        
        [MethodImpl(Inline)]
        EncodedMethod(OpIdentity id, MethodInfo src, MemoryAddress location)
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

        public void Deconstruct(out OpIdentity id, out MethodInfo src, out MemoryAddress location)
        {
            id = Id;
            src = Source;
            location = Location;
        }

    }
}