//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public struct bits<T> : IBitContainer<bits<T>,T>
        where T : unmanaged
    {
        T Storage;

        public ushort Width {get; private set;}

        [MethodImpl(Inline)]
        public bits(T src)
        {
            Storage = src;
            Width = (ushort)width<T>();
        }

        [MethodImpl(Inline)]
        public bits(T src, ushort width)
        {
            Storage = src;
            Width = width;
        }

        public T Value
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        public string Format()
            => BitFormatter.format(Storage, Width);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(bits<T> src)
            => Structs.eq(this, src);

        public override int GetHashCode()
            => Storage.GetHashCode();

        public override bool Equals(object src)
            => src is bits<T> b && Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator bits<T>(T src)
            => new bits<T>(src);
    }
}