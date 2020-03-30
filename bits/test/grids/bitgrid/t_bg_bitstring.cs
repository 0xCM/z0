//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Nats;
    
    public class t_bg_bitstring : t_bg<t_bg_bitstring>
    {        
       public void nbg_bitstring_11x3x16()
            => nbg_bitstring_check(n11,n3, z16);
            
        public void nbg_bitstring_64x4x8()
            => nbg_bitstring_check(n64,n4, z8);

        public void nbg_bitstring_113x201x64()
            => nbg_bitstring_check(TypeNats.seq(n1,n1,n3), TypeNats.seq(n2,n0,n1), z64);
    }
}