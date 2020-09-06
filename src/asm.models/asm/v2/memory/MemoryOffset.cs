//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MemoryOffset : IAddressable<MemoryOffset, MemoryAddress>
    {
        public readonly MemoryAddress Base;

        public readonly ulong Offset;

        public readonly NumericWidth OffsetWidth;

        /// <summary>
        /// The offset magnitude presented as an address
        /// </summary>
        public MemoryAddress OffsetAddress
        {
            [MethodImpl(Inline)]
            get => Offset;
        }

        /// <summary>
        /// The absolute address
        /// </summary>
        public MemoryAddress Absolute
        {
            [MethodImpl(Inline)]
            get => IsEmpty ? MemoryAddress.Empty : (Base + Offset);
        }

        MemoryAddress IAddressable<MemoryAddress>.Base
        {
            [MethodImpl(Inline)]
            get => Absolute;
        }

        MemoryAddress IAddressable.Base
            => IsEmpty ? MemoryAddress.Empty : (Base + Offset);

        public MemoryOffset Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Base.Location == 0 && Offset == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public static bool operator==(MemoryOffset a, MemoryOffset b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(MemoryOffset a, MemoryOffset b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public MemoryOffset(MemoryAddress @base, ulong offset, NumericWidth width)
        {
            Base = @base;
            Offset = offset;
            OffsetWidth = width;
        }

        public string Format(char delimiter)
        {
            MemoryAddress offset = Offset;
            return string.Concat(Base.Format(), delimiter, offset.Format(OffsetWidth));
        }

        [MethodImpl(Inline)]
        public MemoryOffset AccrueOffset(ulong dx)
            => new MemoryOffset(Base, Offset + dx, OffsetWidth);

        public string Format()
            => Format(Chars.Space);

        [MethodImpl(Inline)]
        public int CompareTo(MemoryOffset src)
            => Base == src.Base ? (Offset.CompareTo(src.Offset)) : Base.CompareTo(src.Base);

        [MethodImpl(Inline)]
        public bool Equals(MemoryOffset src)
            => Base == src.Base && Offset == src.Offset;

        public override int GetHashCode()
            => (int)z.hash((ulong)Base, (ulong)Offset);

        public override bool Equals(object obj)
            => obj is MemoryOffset a && Equals(a);

        public override string ToString()
            => Format();

        public static MemoryOffset Empty
            => new MemoryOffset(0ul, 0, 0);
    }
}