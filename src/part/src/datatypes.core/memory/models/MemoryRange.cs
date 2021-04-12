//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines an inclusive address range
    /// </summary>
    public readonly struct MemoryRange : IMemoryRange<MemoryRange>
    {
        [MethodImpl(Inline)]
        public static ITextParser<MemoryRange> parser()
            => MemoryRangeParser.Service;

        /// <summary>
        /// The inclusive address at which the range begins
        /// </summary>
        public MemoryAddress Min {get;}

        /// <summary>
        /// The inclusive address at which the range ends
        /// </summary>
        public MemoryAddress Max {get;}

        [MethodImpl(Inline)]
        public MemoryRange(MemoryAddress min, MemoryAddress max)
        {
            Min = min;
            Max = max;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => (ulong)Max - (ulong)Min;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Size == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Size != 0;
        }

        public override int GetHashCode()
            => (int)alg.hash.combine((ulong)Min, (ulong)Max);

        [MethodImpl(Inline)]
        public bool Equals(MemoryRange src)
            => Min == src.Min && Max == src.Max;

        public override bool Equals(object obj)
            => obj is MemoryRange x && Equals(x);

        [MethodImpl(Inline)]
        public bool Includes(MemoryRange range)
            => range.Min >= Min && range.Max <= Max;

        [MethodImpl(Inline)]
        public bool Includes(MemoryAddress address)
            => address.Location >= Min && address.Location <= Max;

        [MethodImpl(Inline)]
        public int CompareTo(MemoryRange other)
            => this == other ? 0 : this < other ? -1 : 1;

        [MethodImpl(Inline)]
        static string enclose(object content, char left, char right)
            => string.Concat(left, $"{content}", right);

        [MethodImpl(Inline)]
        static string bracket(object content)
            => enclose($"{content}", Chars.LBracket, Chars.RBracket);

        public string Format()
            => bracket(string.Concat(Min.Format(), Chars.Comma, Chars.Space, Max.Format()));

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static bool operator==(MemoryRange a, MemoryRange b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(MemoryRange a, MemoryRange b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator<(MemoryRange a, MemoryRange b)
            => a.Min < b.Min;

        [MethodImpl(Inline)]
        public static bool operator>(MemoryRange a, MemoryRange b)
            => a.Min > b.Min;

        [MethodImpl(Inline)]
        public static bool operator<=(MemoryRange a, MemoryRange b)
            => a.Min <= b.Min;

        [MethodImpl(Inline)]
        public static bool operator>=(MemoryRange a, MemoryRange b)
            => a.Min >= b.Min;

        [MethodImpl(Inline)]
        public static implicit operator MemoryRange((MemoryAddress start, MemoryAddress end) src)
            => new MemoryRange(src.start, src.end);

        public static MemoryRange Empty => default;
    }
}