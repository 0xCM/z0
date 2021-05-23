//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Timestamp : IDataTypeComparable<Timestamp>
    {
        readonly ulong Ticks;

        const string Pattern = "yyyy-MM-dd.HH.mm.ss.fff";

        [MethodImpl(Inline)]
        public Timestamp(ulong ticks)
            => Ticks = ticks;

        [MethodImpl(Inline)]
        public string Format()
            => new DateTime((long)Ticks).ToString(Pattern);

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

        public bool IsNonZero
        {
            [MethodImpl(Inline)]
            get => Ticks != 0;
        }

        public uint Hashed
        {
            [MethodImpl(Inline)]
            get => alg.hash.calc(Ticks);
        }

        public override int GetHashCode()
            => (int)Hashed;

        [MethodImpl(Inline)]
        public static implicit operator ulong(Timestamp src)
            => src.Ticks;

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

        public static Timestamp Zero => default;
    }
}