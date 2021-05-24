//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct bits<N,T> : IBitContainer<bits<N,T>,N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        T Storage;

        [MethodImpl(Inline)]
        public bits(T src)
        {
            Storage = src;
        }

        public ushort Width
        {
            [MethodImpl(Inline)]
            get => NatValues.nat16u<N>();
        }

        public T Value
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        public string Format()
            => bit.format(Storage, Width);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(bits<N,T> src)
            => Structs.eq(this, src);

        public override int GetHashCode()
            => Storage.GetHashCode();

        public override bool Equals(object src)
            => src is bits<N,T> b && Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator bits<N,T>(T src)
            => new bits<N,T>(src);
    }
}