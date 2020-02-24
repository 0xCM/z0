//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    public readonly struct N127 : INatSeq<N127>, INatPrior<N127,N128>
    {
        public const ulong Value = (1ul << 7) - 1;      

        public static N127 Rep => default;
        
        public static NatSeq<N1,N2,N7> Seq => default;
        
        [MethodImpl(Inline)]
        public static implicit operator int(N127 src) => 127;
        
        
        
        public ulong NatValue => Value;
                
        public override string ToString() 
            => Value.ToString();
    }


}