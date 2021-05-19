//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [Datatype]
    public readonly struct Mb
    {
        const string UOM = " mb";

        public uint Count {get;}

        [MethodImpl(Inline)]
        public Mb(uint src)
        {
            Count = src;
        }

        public string Format()
            => (Count != 0 ? Count.ToString("#,#") : "0") + UOM;


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(Mb src)
            => Count == src.Count;

        public override int GetHashCode()
            => (int)alg.hash.calc(Count);

        public override bool Equals(object obj)
            => obj is Mb x && Equals(x);

        [MethodImpl(Inline)]
        public static bool operator ==(Mb a, Mb b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(Mb a, Mb b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator uint(Mb src)
            => src.Count;
    }
}