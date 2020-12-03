//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = MemoryModels;

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
        public MemoryOffset(MemoryAddress @base, ulong offset, NumericWidth width)
        {
            Base = @base;
            Offset = offset;
            OffsetWidth = width;
        }

        public string Format(char delimiter)
            => MemoryModels.format(this, delimiter);

        [MethodImpl(Inline)]
        public MemoryOffset AccrueOffset(ulong dx)
            => api.accrue(this, dx);
        public string Format()
            => api.format(this, Chars.Space);

        [MethodImpl(Inline)]
        public int CompareTo(MemoryOffset src)
            => api.compare(this,src);

        [MethodImpl(Inline)]
        public bool Equals(MemoryOffset src)
            => api.equals(this, src);

        public override int GetHashCode()
            => api.hash(this);

        public override bool Equals(object obj)
            => obj is MemoryOffset a && Equals(a);

        public override string ToString()
            => Format();

        public static MemoryOffset Empty
            => default;

        [MethodImpl(Inline)]
        public static bool operator==(MemoryOffset a, MemoryOffset b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(MemoryOffset a, MemoryOffset b)
            => !a.Equals(b);

        MemoryAddress IAddressable<MemoryAddress>.Address
        {
            [MethodImpl(Inline)]
            get => Absolute;
        }

        MemoryAddress IAddressable.Address
            => IsEmpty ? MemoryAddress.Empty : (Base + Offset);
    }
}