//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    /// <summary>
    /// Defines an inclusive address range
    /// </summary>
    public readonly struct MemoryRange : IMemoryRange<MemoryRange>
    {        
        public readonly MemoryAddress Start;

        public readonly MemoryAddress End;

        [MethodImpl(Inline)]
        public static MemoryRange Define(MemoryAddress start, MemoryAddress end)
            => new MemoryRange(start,end);
            
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

        [MethodImpl(Inline)]
        public static implicit operator MemoryRange((MemoryAddress start, MemoryAddress end) src)
            => new MemoryRange(src.start, src.end);

        [MethodImpl(Inline)]
        public MemoryRange(MemoryAddress start, MemoryAddress end)
        {
            Start = start;
            End = end;
        }
        
        [MethodImpl(Inline)]
        public void Deconstruct(out MemoryAddress start, out MemoryAddress end)
        {
            start = this.Start;
            end = this.End;
        }

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

        [MethodImpl(Inline)]
        static string enclose(object content, char left, char right)
            => string.Concat(left, $"{content}", right);

        [MethodImpl(Inline)]
        static string bracket(object content)
            => enclose($"{content}", Chars.LBracket, Chars.RBracket);
        
        public string Format()
            => bracket(string.Concat(Start.Format(), Chars.Comma, Chars.Space, End.Format()));

        public static MemoryRange Empty => default;

    }
}