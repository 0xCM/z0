//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Root;

    /// <summary>
    /// Defines an inclusive address range
    /// </summary>
    public readonly struct MemoryRange : IEquatable<MemoryRange>, IComparable<MemoryRange>
    {
        public static MemoryRange Empty => default;
        
        public readonly MemoryAddress Start;

        public readonly MemoryAddress End;

        public ulong Length 
        {
            [MethodImpl(Inline)]
            get => End - Start;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Length == 0;
        }

        [MethodImpl(Inline)]
        public static bool operator==(MemoryRange a, MemoryRange b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(MemoryRange a, MemoryRange b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator<(MemoryRange a, MemoryRange b)
            => a.Start < b.Start;

        [MethodImpl(Inline)]
        public static bool operator>(MemoryRange a, MemoryRange b)
            => a.Start > b.Start;

        [MethodImpl(Inline)]
        public static bool operator<=(MemoryRange a, MemoryRange b)
            => a.Start <= b.Start;

        [MethodImpl(Inline)]
        public static bool operator>=(MemoryRange a, MemoryRange b)
            => a.Start >= b.Start;

        /// <summary>
        /// Attempts to parse an address segment in standard form, [start,end]
        /// </summary>
        /// <param name="src">The source text</param>
        public static Option<MemoryRange> Parse(string src)    
             => from i0 in src.FirstIndexOf(text.lbracket()).ToOption()
                from i1 in src.FirstIndexOf(text.rbracket()).ToOption()
                let inner = src.Substring(i0 + 1, i1 - i0 - 1)
                let parts = inner.Split(text.comma()).Trim()
                where parts.Length == 2
                from start in Hex.parse(parts[0]).ToOption()
                from end in Hex.parse(parts[1]).ToOption()
                select Define(start, end);
                                

        [MethodImpl(Inline)]
        public static MemoryRange Define(MemoryAddress start, MemoryAddress end)
            => new MemoryRange(start,end);

        [MethodImpl(Inline)]
        public static implicit operator MemoryRange((ulong start, ulong end) src)
            => new MemoryRange(src.start, src.end);

        [MethodImpl(Inline)]
        MemoryRange(MemoryAddress start, MemoryAddress end)
        {
            this.Start = start;
            this.End = end;
        }
        
        [MethodImpl(Inline)]
        public void Deconstruct(out MemoryAddress start, out MemoryAddress end)
        {
            start = this.Start;
            end = this.End;
        }

        public string Format()
            => text.bracket(text.concat(Start.Format(), text.comma(), text.space(), End.Format()));

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => HashCode.Combine(Start,End);

        [MethodImpl(Inline)]
        public bool Equals(MemoryRange src)
            => Start == src.Start && End == src.End;
        
        public override bool Equals(object obj)
            => obj is MemoryRange x && Equals(x);

        [MethodImpl(Inline)]
        public bool Includes(MemoryRange range)
            => range.Start >= Start && range.End <= End;

        [MethodImpl(Inline)]
        public bool Includes(MemoryAddress address)
            => address.Location >= Start && address.Location <= End;

        [MethodImpl(Inline)]
        public int CompareTo(MemoryRange other)
            => this == other ? 0 : this < other ? -1 : 1;
    }
}