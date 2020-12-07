//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Captures a hash code for structured content
    /// </summary>
    [Datatype]
    public readonly struct Hashed<C> : IHashed<Hashed<C>>
        where C : struct
    {
        public uint Hash {get;}

        public C Content {get;}

        [MethodImpl(Inline)]
        public Hashed(in C content, uint hash)
        {
            Content = content;
            Hash = hash;
        }

        public override int GetHashCode()
            => (int) Hash;
    }
}