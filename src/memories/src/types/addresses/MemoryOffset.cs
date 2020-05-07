//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MemoryOffset : 
        IIdentification<MemoryOffset>, 
        IAddressable, 
        INullaryKnown, 
        INullary<MemoryOffset>
    {
        public readonly ushort Offset;

        public static MemoryOffset Empty => new MemoryOffset(0);

        public readonly MemoryAddress Base;

        MemoryAddress IAddressable.Address => Base;

        public MemoryOffset Zero  { [MethodImpl(Inline)] get => Empty; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Offset == 0; }

        public bool IsNonEmpty  { [MethodImpl(Inline)] get => Offset != 0; }

        public string IdentityText 
            => Offset.ToString("x4") + "h";

        [MethodImpl(Inline)]
        public static MemoryOffset Define(MemoryAddress @base, ushort offset)
            => new MemoryOffset(@base, offset);

        [MethodImpl(Inline)]
        public static MemoryOffset Define(ushort offset)
            => new MemoryOffset(offset);

        [MethodImpl(Inline)]
        public static implicit operator MemoryOffset(ushort src)
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(MemoryOffset src)
            => src.Offset;

        [MethodImpl(Inline)]
        public static bool operator==(MemoryOffset a, MemoryOffset b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(MemoryOffset a, MemoryOffset b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        MemoryOffset(ushort offset)
        {
            Base = 0ul;
            Offset = offset;
        }

        [MethodImpl(Inline)]
        MemoryOffset(MemoryAddress @base, ushort offset)
        {
            Base = @base;
            Offset = offset;
        }
        
        public string Format()
            => IdentityText;

        [MethodImpl(Inline)]
        public int CompareTo(MemoryOffset other)
            => this == other ? 0 : Offset < other.Offset ? -1 : 1;

        [MethodImpl(Inline)]
        public bool Equals(MemoryOffset src)
            => Offset == src.Offset;

        public override int GetHashCode()
            => Offset.GetHashCode();

        public override bool Equals(object obj)
            => obj is MemoryOffset a && Equals(a);                    

        public override string ToString() 
            => Format();
    }
}