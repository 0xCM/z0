//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// The singleton type representative for 0
    /// </summary>
    public readonly struct N0 : 
        INatPrimitive<N0>, 
        INatSeq<N0>, 
        INatEven<N0> 
    {
        public const ulong Value = 0;

        public const string Text = "0";

        public ulong NatValue => Value;

        public string NatText => Text;

        [MethodImpl(Inline)]
        public static implicit operator int(N0 src) => (int)Value;
        
        public override string ToString() => Text;
    }
}