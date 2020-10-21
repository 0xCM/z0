//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct MemoryOffset : IAddressable<MemoryOffset, MemoryAddress>
    {
        [MethodImpl(Inline), Op]
        public static string format(in MemoryOffset moffs)
            => text.concat(((ushort)moffs.Offset).FormatAsmHex(), Chars.Space, moffs.Absolute);

        public static Span<string> format(in MemoryOffsets offsets)
        {
            var empty = MemoryOffset.Empty;
            var dst = sys.alloc<string>(offsets.Count);
            format(offsets,dst);
            return dst;
        }

        public static void format(in MemoryOffsets offsets, Span<string> dst)
        {
            var empty = MemoryOffset.Empty;
            for(var k=0u; k<offsets.Count; k++)
            {
                ref readonly var prior = ref (k == 0 ? ref empty : ref offsets[k-1]);
                ref readonly var current = ref offsets[k];
                seek(dst,k) = format(prior, current);
            }
        }

        public static string format(in MemoryOffset prior, in MemoryOffset moffs)
        {
            const char Sep = Chars.Space;
            const NumericWidth OffsetWidth = NumericWidth.W16;
            const string BaseIndicator = "@base";
            const string PriorIndicator = "@prior";
            const char Selector = Chars.Plus;

            var offset = moffs.OffsetAddress;
            var offsetFmt = offset.Format(OffsetWidth);
            var moffsBase = text.concat(BaseIndicator, Selector, offsetFmt);
            var priorFmt = text.concat(PriorIndicator, Selector, prior.Absolute.Format(OffsetWidth));

            if(prior.IsEmpty)
                return text.concat(offsetFmt, Sep, moffs.Absolute, Sep, moffsBase, Sep, priorFmt);

            var delta = moffs.Absolute - prior.Absolute;
            var deltaFmt = delta.Format(OffsetWidth);
            var moffsPrior = text.concat(PriorIndicator, Selector, deltaFmt);

            return text.concat(offsetFmt, Sep, moffs.Absolute, Sep, moffsBase, Sep, moffsPrior);
        }

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

        MemoryAddress IAddressable<MemoryAddress>.Address
        {
            [MethodImpl(Inline)]
            get => Absolute;
        }

        MemoryAddress IAddressable.Address
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