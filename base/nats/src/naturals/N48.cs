//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N48 : INatSeq<N48>
    {
        public const ulong Value = 48;

        public static N48 Rep => default;

        public static NatSeq<N4,N8> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N48 src) => 48;

        

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}