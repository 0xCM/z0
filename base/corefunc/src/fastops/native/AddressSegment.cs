//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
 
    using static zfunc;

    /// <summary>
    /// Defines an inclusive address range
    /// </summary>
    public readonly struct AddressSegment : IEquatable<AddressSegment>
    {
        /// <summary>
        /// Attempts to parse an address segment in standard form, [start,end]
        /// </summary>
        /// <param name="src">The source text</param>
        public static Option<AddressSegment> Parse(string src)    
             => from i0 in src.FirstIndexOf(AsciSym.LBracket)
                from i1 in src.FirstIndexOf(AsciSym.RBracket)
                let inner = src.Substring(i0 + 1, i1 - i0 - 1)
                let parts = inner.Split(AsciSym.Comma).Trim()
                where parts.Length == 2
                from start in Hex.parse(parts[0])
                from end in Hex.parse(parts[1])
                select Define(start, end);
                                
        public static AddressSegment Empty => default;
        
        public readonly ulong Start;

        public readonly ulong End;

        [MethodImpl(Inline)]
        public static AddressSegment Define(ulong start, ulong end)
            => new AddressSegment(start,end);

        [MethodImpl(Inline)]
        public static implicit operator AddressSegment((ulong start, ulong end) src)
            => new AddressSegment(src.start, src.end);

        [MethodImpl(Inline)]
        AddressSegment(ulong start, ulong end)
        {
            this.Start = start;
            this.End = end;
        }
        
        [MethodImpl(Inline)]
        public void Deconstruct(out ulong start, out ulong end)
        {
            start = this.Start;
            end = this.End;
        }

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

        public string Format()
            => bracket(concat(
                Start.FormatHex(false), 
                AsciSym.Comma, 
                AsciSym.Space, 
                End.FormatHex(false))
                );

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => HashCode.Combine(Start,End);

        public bool Equals(AddressSegment src)
            => Start == src.Start && End == src.End;
        
        public override bool Equals(object obj)
            => obj is AddressSegment x && Equals(x);
    }


}