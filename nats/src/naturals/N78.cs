//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    public readonly struct N78 : INatSeq<N78,N7,N8>
    {
        public const ulong Value = 78;


        [MethodImpl(Inline)]
        public static implicit operator int(N78 src) => 78;

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}