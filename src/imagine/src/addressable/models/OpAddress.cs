//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    using A = OpAddress;
    using W = W64;
    using T = MemoryAddress;

    /// <summary>
    /// Pairs a located operation with, well, its location
    /// </summary>
    public readonly struct OpAddress : IAddress<A,W,T>
    {        
        public readonly MemoryAddress Location;

        public readonly OpUri OpUri;        
        
        public bool IsEmpty 
        {  
            [MethodImpl(Inline)] 
            get => OpUri.IsEmpty && Location.IsEmpty;
        }

        public bool IsNonEmpty 
        { 
            [MethodImpl(Inline)] 
            get => !IsEmpty; 
        }

        public OpAddress Zero 
            => Empty;

        [MethodImpl(Inline)]
        public static implicit operator OpAddress((OpUri uri, MemoryAddress address) src)
            => new OpAddress(src.uri, src.address);

        [MethodImpl(Inline)]
        public OpAddress(OpUri uri, MemoryAddress address)
        {
            OpUri = uri;
            Location = address;
        }
 
         T IAddress<T>.Location 
            => Location;

        public string Format()
            => OpUri.Format() + Chars.Dash + Location.Format();

        public static OpAddress Empty 
            => (OpUri.Empty, MemoryAddress.Empty);
        
        public uint Hash
        {
            [MethodImpl(Inline)]
            get => Location.Hash;
        }

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public bool Equals(A src)        
            => Location == src.Location;

        public override bool Equals(object src)        
            => src is A a && Equals(a);

        [MethodImpl(Inline)]
        public int CompareTo(A src)
            => Location == src.Location ? 0 : Location < src.Location ? -1 : 1;
    }
}