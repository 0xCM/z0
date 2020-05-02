//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct LocalAddress : ITextual, INullary<LocalAddress>
    {
        readonly ushort Offset;

        public static LocalAddress Empty => default(LocalAddress);

        [MethodImpl(Inline)]
        public static LocalAddress From(ushort offset)
            => new LocalAddress(offset);

        [MethodImpl(Inline)]
        public static LocalAddress From(int offset)
            => new LocalAddress(offset);

        [MethodImpl(Inline)]
        public static LocalAddress operator+(LocalAddress x, ushort y)
            => new LocalAddress(x.Offset + y);

        [MethodImpl(Inline)]
        public static LocalAddress operator+(LocalAddress x, int y)
            => new LocalAddress(x.Offset + y);

        [MethodImpl(Inline)]
        public static bool operator==(LocalAddress x, LocalAddress y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(LocalAddress x, LocalAddress y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator LocalAddress(ushort offset)
            => new LocalAddress(offset);

        [MethodImpl(Inline)]
        public static implicit operator LocalAddress(int offset)
            => new LocalAddress((ushort)offset);

        [MethodImpl(Inline)]
        LocalAddress(int offset)
        {
            Offset = (ushort)offset;
        }

        [MethodImpl(Inline)]
        LocalAddress(ushort offset)
        {
            Offset = offset;
        }

        public LocalAddress Zero => Empty;

        [MethodImpl(Inline)]
        public string Format()
            => Offset.FormatSmallHex(true);
        
        public bool Equals(LocalAddress src)        
            => Offset == src.Offset;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Offset.GetHashCode();
        
        public override bool Equals(object src)
            => src is LocalAddress l && Equals(l);
    }
}