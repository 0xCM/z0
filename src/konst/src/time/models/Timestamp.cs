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

    public readonly struct Timestamp : ITextual, IComparable<Timestamp>, IEquatable<Timestamp>
    {
        readonly ulong Ticks;

        [MethodImpl(Inline)]
        public Timestamp(ulong ticks)
            => Ticks = ticks;        

        [MethodImpl(Inline)]
        public static bool operator <(Timestamp a, Timestamp b)
            => a.Ticks < b.Ticks;

        [MethodImpl(Inline)]
        public static bool operator <=(Timestamp a, Timestamp b)
            => a.Ticks <= b.Ticks;

        [MethodImpl(Inline)]
        public static bool operator >(Timestamp a, Timestamp b)
            => a.Ticks > b.Ticks;

        [MethodImpl(Inline)]
        public static bool operator >=(Timestamp a, Timestamp b)
            => a.Ticks >= b.Ticks;

        [MethodImpl(Inline)]
        public static bool operator ==(Timestamp a, Timestamp b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(Timestamp a, Timestamp b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator Timestamp(DateTime src)
            => new Timestamp((ulong)src.Ticks);

        [MethodImpl(Inline)]
        public string Format()
            => new DateTime((long)Ticks).ToLexicalString();

        [MethodImpl(Inline)]
        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(Timestamp src)
            => Ticks == src.Ticks;

        [MethodImpl(Inline)]
        public override bool Equals(object src)
            => src is Timestamp x && Equals(x);


        [MethodImpl(Inline)]        
        public int CompareTo(Timestamp src)
            => Ticks.CompareTo(src.Ticks);
        
        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => hash(Ticks);
        }

        public override int GetHashCode()
            => (int)Hashed;
    }
}