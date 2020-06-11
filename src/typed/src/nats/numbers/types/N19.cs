//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct N19 : 
        INatNumber<N19>,
        INatSeq<N19>
    {
        public const ulong Value = 19;

        public const string Text = "19";

        [MethodImpl(Inline)]
        public static implicit operator int(N19 src) => 19;

        public ulong NatValue 
            => Value;

        [MethodImpl(Inline)]
        public string Format()
            => Text;             

        public override string ToString() 
            => Text;
    }
}