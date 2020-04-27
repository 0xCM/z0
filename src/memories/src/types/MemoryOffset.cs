//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MemoryOffset : IIdentification<MemoryOffset>, IAddressable
    {
        public static MemoryOffset Zero => default;

        public readonly MemoryAddress Base;

        public readonly ushort Offset;

        MemoryAddress IAddressable.Address => Base;

        public bool NonZero
        {
            [MethodImpl(Inline)]
            get => Offset != 0;
        }

        public string Identifier 
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
            this.Base = 0ul;
            this.Offset = offset;
        }

        [MethodImpl(Inline)]
        MemoryOffset(MemoryAddress @base, ushort offset)
        {
            this.Base = @base;
            this.Offset = offset;
        }
        
        public string Format()
            => Identifier;

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