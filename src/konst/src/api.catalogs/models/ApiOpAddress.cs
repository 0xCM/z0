//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using A = ApiOpAddress;
    using W = W64;
    using T = MemoryAddress;

    /// <summary>
    /// Pairs a located operation with, well, its location
    /// </summary>
    public readonly struct ApiOpAddress : IAddress<A,W,T>
    {
        public MemoryAddress Location {get;}

        public ApiMetadataUri Uri {get;}

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Uri.IsEmpty && Location.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public ApiOpAddress Zero
            => Empty;

        [MethodImpl(Inline)]
        public ApiOpAddress(ApiMetadataUri uri, MemoryAddress address)
        {
            Uri = uri;
            Location = address;
        }

        public string Format()
            => Uri.Format() + Chars.Dash + Location.Format();

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

        [MethodImpl(Inline)]
        public static implicit operator ApiOpAddress((ApiMetadataUri uri, MemoryAddress address) src)
            => new ApiOpAddress(src.uri, src.address);

        public static ApiOpAddress Empty
            => (ApiMetadataUri.Empty, MemoryAddress.Empty);
    }
}