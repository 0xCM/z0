//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Captures a hash code
    /// </summary>
    public readonly struct Hashed : IHashed
    {        
        public uint Hash {get;}

        [MethodImpl(Inline)]
        public Hashed(uint src)
            => Hash = src;

        [MethodImpl(Inline)]
        public Hashed(int src)
            => Hash = (uint)src;

        public int HashCode
        {
            [MethodImpl(Inline)]
            get => (int)Hash;
        }        
    }
        
    /// <summary>
    /// Captures a hash code for structured content
    /// </summary>
    public readonly struct Hashed<C> : IHashed<Hashed<C>,C>
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
        
        public int HashCode
        {
            [MethodImpl(Inline)]
            get => (int)Hash;
        }        
    }
}